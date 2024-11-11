CREATE DATABASE dbAgenda;
USE dbAgenda;

CREATE TABLE tbUsuarios(
	nome VARCHAR(80) NOT NULL,
    usuario VARCHAR(40) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(8) NOT NULL
    );
    
select * from tbUsuarios;  
  
CREATE TABLE tbCategorias(
	cod_categoria INT AUTO_INCREMENT PRIMARY KEY,
	categoria VARCHAR(60) NOT NULL
	);

SELECT * FROM tbCategorias;

  
  
  // exemplo/ teste 
  SELECT * from tbUsuarios
  WHERE usuario ="godo" and binary senha ="AlexLind";