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
	categoria VARCHAR(60) NOT NULL,
    usuario VARCHAR(20)
	);

select cod_categoria AS 'Código', categoria AS 'Categoria' from tbCategorias;


CREATE USER 'babalu'@'%' IDENTIFIED BY '1234567';
select * from mysql.user;
  
// exemplo/ teste 
  SELECT * from tbUsuarios
  WHERE usuario ="godo" and binary senha ="AlexLind";

//Para aparecer o usuario nas modificações de categorias 
DELIMITER $$    
CREATE TRIGGER trInsertCategoria 
BEFORE
INSERT
ON tbCategorias 
FOR EACH ROW
BEGIN
	SET NEW.usuario = CURRENT_USER();
END;
$$

DELIMITER ;


// tbLog

CREATE TABLE tbLog(
	cod_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(40),
    data_hora DATETIME,
    descriçao VARCHAR(80)
);

DELIMITER $$    
CREATE TRIGGER trlogcategoriadelete 
AFTER
DELETE
ON tbCategorias
FOR EACH ROW
BEGIN
	INSERT INTO tbLog
    (usuario,
    data_hora,
    descriçao)
    VALUES 
	(USER(),
    CURRENT_TIMESTAMP(),
    CONCAT("A categoria", old.categoria, "foi excluida.")
    );
    
END;
$$

DELIMITER ;

