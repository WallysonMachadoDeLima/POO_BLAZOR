using Microsoft.EntityFrameworkCore;
using POO_BLAZOR.Components;
using POO_BLAZOR.Data;

var builder = WebApplication.CreateBuilder(args);

// Adicionar servi�os ao cont�iner.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configurar o AppDbContext para usar MySQL
builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21)) // Certifique-se de usar a vers�o correta do MySQL
    ));

builder.Services.AddQuickGridEntityFrameworkAdapter();

var app = builder.Build();

// Configurar o pipeline de requisi��es HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
