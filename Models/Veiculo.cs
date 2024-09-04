using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace POO_BLAZOR.Models
{
    

    public class Veiculo
    {
        [Key]
        [Column("id_veiculo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "A placa é obrigatória.")]
        [StringLength(7, ErrorMessage = "A placa deve ter 7 caracteres.")]
        public string Placa { get; set; } = string.Empty;

        [Required(ErrorMessage = "O modelo é obrigatório.")]
        public string Modelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O ano de fabricação é obrigatório.")]
        [Range(1886, 9999, ErrorMessage = "O ano de fabricação deve ser válido.")]
        public string AnoFabricacaoModelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O chassi é obrigatório.")]
        [StringLength(17, ErrorMessage = "O chassi deve ter 17 caracteres.")]
        public string Chassis { get; set; } = string.Empty;

        [Required(ErrorMessage = "O renavam é obrigatório.")]
        [Column("renavam_veiculo")]
        [StringLength(11, ErrorMessage = "O renavam deve ter 11 caracteres.")]
        public string RenavamVeiculo { get; set; } = string.Empty;

        [Column("fk_id_cor")]
        [Required(ErrorMessage = "A cor é obrigatória.")]
        public int? FkIdCor { get; set; }

        [ForeignKey("FkIdCor")]
        public Cor? Cor { get; set; } 

        [Column("fk_id_marca")]
        [Required(ErrorMessage = "A marca é obrigatória.")]
        public int? FkIdMarca { get; set; }

        [ForeignKey("FkIdMarca")]
        public Marca? Marca { get; set; } 


    }

    public class Cor
    {
        [Column("id_cor")]
        public int Id { get; set; }

        [Column("nome_cor")]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    }

    public class Marca
    {
        [Column("id_marca")]
        public int Id { get; set; }

        [Column("nome_marca")]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    }
}
