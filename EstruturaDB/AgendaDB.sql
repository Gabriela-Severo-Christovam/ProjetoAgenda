CREATE DATABASE dbAgenda;
USE dbAgenda;

CREATE TABLE tbUsuarios(
	nome VARCHAR(80) NOT NULL,
    usuario VARCHAR(40) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(8) NOT NULL
    );

CREATE TABLE tbCategorias(
	cod_categoria INT AUTO_INCREMENT PRIMARY KEY,
	categoria VARCHAR(60) NOT NULL,
    usuario VARCHAR(20)
	);

CREATE TABLE tbContato(
	contato VARCHAR(80) NOT NULL,
    telefone VARCHAR(15) primary key,
	categoria VARCHAR(30) 
    );

CREATE TABLE tbLog(
	cod_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(40),
    data_hora DATETIME,
    descriçao VARCHAR(80)
);

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



DELIMITER $$    
CREATE TRIGGER trloginserirContato 
AFTER
INSERT
ON tbContato
FOR EACH ROW
BEGIN
	INSERT INTO tbLog
    (usuario,
    data_hora,
    descriçao)
    VALUES 
	(USER(),
    CURRENT_TIMESTAMP(),
    CONCAT("O contato", new.contato, "foi inserido.")
    );
    
END;
$$

DELIMITER ;

///////

DELIMITER $$    
CREATE TRIGGER trlogdeleteContato 
AFTER
DELETE
ON tbContato
FOR EACH ROW
BEGIN
	INSERT INTO tbLog
    (usuario,
    data_hora,
    descriçao)
    VALUES 
	(USER(),
    CURRENT_TIMESTAMP(),
    CONCAT("O contato", old.contato, "foi excluido.")
    );
    
END;
$$

DELIMITER ;

DELIMITER $$    
CREATE TRIGGER TrLogAlterarSenha 
AFTER
UPDATE
ON tbUsuarios
FOR EACH ROW
BEGIN
	INSERT INTO tbLog
    (usuario,
    data_hora,
    descriçao)
    VALUES 
	(USER(),
    CURRENT_TIMESTAMP(),
    CONCAT("A senha ", old.senha, 'foi alterada para.', new.senha)
    );
    
END;
$$

DELIMITER ;


DELIMITER $$    
CREATE TRIGGER trlogDeleteUsuario 
AFTER
DELETE
ON tbUsuarios
FOR EACH ROW
BEGIN
	INSERT INTO tbLog
    (usuario,
    data_hora,
    descriçao)
    VALUES 
	(USER(),
    CURRENT_TIMESTAMP(),
    CONCAT("O usuario", old.usuario, "foi deletado.")
    );
    
END;
$$

DELIMITER ;

DELIMITER $$    
CREATE TRIGGER trlogAlterarContato 
AFTER
UPDATE 
ON tbContato
FOR EACH ROW
BEGIN
	INSERT INTO tbLog
    (usuario,
    data_hora,
    descriçao)
    VALUES 
	(USER(),
    CURRENT_TIMESTAMP(),
    CONCAT("O Contato", old.contato, 'foi alterado para.', new.contato, '\n'
		   'A categoria', old.categoria, 'foi alterada para', new.categoria)
    );
    
END;
$$

DELIMITER ;