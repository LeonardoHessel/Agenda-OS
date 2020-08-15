DROP DATABASE IF EXISTS `agenda`;
CREATE DATABASE `agenda`;
USE `agenda`;

DROP TABLE IF EXISTS `log`;
CREATE TABLE `log` (
	`id` INT AUTO_INCREMENT,
    `datahora` DATETIME NOT NULL,
    `descricao` TEXT,
	PRIMARY KEY (`id`)
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario`(
	`id` INT PRIMARY KEY AUTO_INCREMENT,
    `login` VARCHAR(45) NOT NULL UNIQUE,
    `senha` VARCHAR(45) NOT NULL,
    `nome` VARCHAR(45),
    `nasc` DATE,
    `sexo` SET('Feminino','Masculino'),
    `rg` CHAR(9),
    `cpf` CHAR(11),
    `cnh` CHAR(11),
    `imgperfil` varchar(250),
    `del` BOOL DEFAULT FALSE
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `modulo`;
CREATE TABLE IF NOT EXISTS `modulo`(
	`id` INT PRIMARY KEY AUTO_INCREMENT,
    `grupo` VARCHAR(20),
    `descricao` VARCHAR(50),
    `restricao` BOOL DEFAULT FALSE
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `permissao`;
CREATE TABLE IF NOT EXISTS `permissao`(
	`usuario` INT,
    `modulo` INT,
    `acesso` BOOL DEFAULT FALSE,
    PRIMARY KEY(`usuario`,`modulo`),
    FOREIGN KEY (`usuario`) REFERENCES `usuario`(`id`),
    FOREIGN KEY (`modulo`) REFERENCES `modulo`(`id`)
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `contador`;
CREATE TABLE IF NOT EXISTS `contador`(
	`id` INT AUTO_INCREMENT,
    `nome` VARCHAR(250),
    `telefone` VARCHAR(250),
    `email` VARCHAR(250),
    PRIMARY KEY(`id`)
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `empresa`;
CREATE TABLE IF NOT EXISTS `empresa`(
	`id` INT AUTO_INCREMENT,
    `cnpj` CHAR(14) UNIQUE,
    `ie` CHAR(12) UNIQUE,
    `razao` VARCHAR(60),
    `nome` VARCHAR(60),
    `regime` SET('Lucro','Simples'),
    `contador` INT,
    `logradouro` VARCHAR(60),
    `numero` VARCHAR(6),
    `complemento` VARCHAR(20),
    `cep` CHAR(8),
    `bairro` VARCHAR(45),
    `municipio` VARCHAR(45),
    `uf` CHAR(2),
    `email` VARCHAR(250),
    `telefone` VARCHAR(60),
    `observacao` TEXT,
    `del` BOOL DEFAULT FALSE,
    PRIMARY KEY(`id`)
    -- FOREIGN KEY (`contador`) REFERENCES `contador`(`id`)
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `os`;
CREATE TABLE IF NOT EXISTS `os`(
	`id` INT AUTO_INCREMENT,
    `empresa` INT,
    `solicitante` VARCHAR(45),
    `usuario` INT,
    `assunto` VARCHAR(50),
    `descricao` TEXT,
    `solucao` TEXT,
    `produto` INT,
    `atendimento` VARCHAR(20),
    `abertura` DATETIME,
    `fechamento` DATETIME,
    `situacao` VARCHAR(20),
    `del` BOOL,
    PRIMARY KEY(`id`),
    FOREIGN KEY (`empresa`) REFERENCES `empresa`(`id`),
    FOREIGN KEY (`usuario`) REFERENCES `usuario`(`id`),
    FOREIGN KEY (`produto`) REFERENCES `produto`(`id`)
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto`(
	`id` INT AUTO_INCREMENT,
    `nome` VARCHAR(100),
    PRIMARY KEY(`id`)
)ENGINE = InnoDB;


-- Procedimentos --
DROP PROCEDURE IF EXISTS `AdcPermissoes`;
DELIMITER $$
CREATE PROCEDURE `AdcPermissoes` (UsuMod INT,Busca CHAR(1))
BEGIN
	DECLARE Usuario INT;
	DECLARE Modulo INT;
    DECLARE TotalU INT;
    DECLARE TotalM INT;
    DECLARE Total INT;
    DECLARE Seq INT DEFAULT 0;    
    SET Usuario = UsuMod;
	SET Modulo = UsuMod;
	SET TotalU = (SELECT COUNT(*) FROM `usuario`);
	SET TotalM = (SELECT COUNT(*) FROM `modulo`);
    IF Busca = 'M' THEN
		SET Total = TotalM;
	ELSE
		SET Total = TotalU;
	END IF;	
    Loop_Busca: LOOP
		IF Busca = 'M' THEN
			SET Modulo = (SELECT `id` FROM `modulo` LIMIT Seq,1);
		ELSE
			SET Usuario = (SELECT `id` FROM `usuario` LIMIT Seq,1);
		END IF;        
		IF Seq < Total THEN
			INSERT INTO `permissao` VALUES(Usuario, Modulo, TRUE);
            SET Seq = Seq + 1;
		ELSE
			LEAVE Loop_Busca;
		END IF;
	END LOOP Loop_Busca;
END $$
DELIMITER ;


-- TRIGGERS --
-- Usuário --
DROP TRIGGER IF EXISTS `AI_Usuario`;
DELIMITER $$
CREATE TRIGGER `AI_Usuario` 
AFTER INSERT ON `usuario` FOR EACH ROW
BEGIN
	INSERT INTO `log` VALUES (0,NOW(),CONCAT(
		"Novo usuário ( ",
        new.id," | ",new.login," | ",new.nome," | ",
        new.nasc," | ",new.sexo," | ",new.rg," | ",
        new.cpf," | ",new.cnh," )"));
	CALL `AdcPermissoes` (new.id,'M');
END $$
DELIMITER ;

DROP TRIGGER IF EXISTS `AU_Usuario`;
DELIMITER $$
CREATE TRIGGER `AU_Usuario` 
AFTER UPDATE ON `usuario` FOR EACH ROW
BEGIN
	INSERT INTO `log` VALUES (0,NOW(),CONCAT(
		"Usuário alterado de (",
        old.id," | ",old.login," | ",old.nome," | ",
        old.nasc," | ",old.sexo," | ",old.rg," | ",
        old.cpf," | ",old.cnh," ) para ( ",
        new.id," | ",new.login," | ",new.nome," | ",
        new.nasc," | ",new.sexo," | ",new.rg," | ",
        new.cpf," | ",new.cnh," )"));
END $$
DELIMITER ;

-- Modulo --
DROP TRIGGER IF EXISTS `AI_Modulo`;
DELIMITER $$
CREATE TRIGGER `AI_Modulo` 
AFTER INSERT ON `modulo` FOR EACH ROW
BEGIN
	CALL `AdcPermissoes` (new.id,'U');
END $$
DELIMITER ;





-- Inserts --
INSERT INTO `usuario` VALUES (0,'Default','123','Default','2020-01-01','','000000000','00000000000','00000000000','..\\..\\Imagens\\usuarios\\user.png',FALSE);

INSERT INTO `modulo` VALUES (0,'Geral','Login',true);
INSERT INTO `modulo` VALUES (0,'Usuários','Ler Usuários',false);
INSERT INTO `modulo` VALUES (0,'Usuários','Gravar Usuários',false);
INSERT INTO `modulo` VALUES (0,'Usuários','Inativar Usuários',false);






/*
DROP TABLE IF EXISTS `anotacao`;
CREATE TABLE IF NOT EXISTS `anotacao`(
	id int primary key auto_increment,
    texto varchar(250)
)ENGINE = InnoDB;
*/





/*
DROP TABLE IF EXISTS ``;
CREATE TABLE IF NOT EXISTS ``(
	
)ENGINE = InnoDB;
*/