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

select cod_categoria AS 'Código', categoria AS 'Categoria' from tbCategorias;


CREATE USER 'babalu'@'%' IDENTIFIED BY '1234567';
select * from mysql.user;
  
  // exemplo/ teste 
  SELECT * from tbUsuarios
  WHERE usuario ="godo" and binary senha ="AlexLind";