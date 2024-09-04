create database bd_poo;
use bd_poo;

CREATE TABLE Marcas (
    id_marca INT PRIMARY KEY AUTO_INCREMENT,
    nome_marca VARCHAR(100) NOT NULL
);

CREATE TABLE Cores (
    id_cor INT PRIMARY KEY AUTO_INCREMENT,
    nome_cor VARCHAR(50) NOT NULL
);

CREATE TABLE veiculos (
    id_veiculo INT PRIMARY KEY AUTO_INCREMENT,
    placa VARCHAR(100) NOT NULL,
    anofabricacaoModelo VARCHAR(150) NOT NULL,
    modelo VARCHAR(150) NOT NULL,
    chassis VARCHAR(150),
    renavam_veiculo VARCHAR(150),
    fk_id_cor INT NULL DEFAULT NULL,
    fk_id_marca INT NULL DEFAULT NULL,
    FOREIGN KEY (fk_id_marca) REFERENCES Marcas(id_marca),
     FOREIGN KEY (fk_id_cor) REFERENCES Cores(id_cor)
);

INSERT INTO Marcas (nome_marca) VALUES ('Ford');
INSERT INTO Marcas (nome_marca) VALUES ('Chevrolet');
INSERT INTO Marcas (nome_marca) VALUES ('Volkswagen');
INSERT INTO Marcas (nome_marca) VALUES ('Fiat');
INSERT INTO Marcas (nome_marca) VALUES ('Toyota');

INSERT INTO Cores (nome_cor) VALUES ('Branco');
INSERT INTO Cores (nome_cor) VALUES ('Preto');
INSERT INTO Cores (nome_cor) VALUES ('Vermelho');
INSERT INTO Cores (nome_cor) VALUES ('Azul');
INSERT INTO Cores (nome_cor) VALUES ('Prata');

INSERT INTO veiculos (placa, anofabricacaoModelo, modelo, chassis, renavam_veiculo, fk_id_cor, fk_id_marca) values  ('12345', '2004', 'tesla', '1111111', '10203040', 1, 1);

