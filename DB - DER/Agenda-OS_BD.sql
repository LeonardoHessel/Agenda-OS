DROP DATABASE `agenda`;
CREATE DATABASE `agenda`;
USE `agenda`;

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario`(
	`id` INT PRIMARY KEY AUTO_INCREMENT,
    `login` VARCHAR(45) NOT NULL UNIQUE,
    `senha` VARCHAR(45) NOT NULL,
    `nome` VARCHAR(45),
    `nasc` DATE,
    `sexo` SET('Feminino','Masculino','Outro'),
    `rg` CHAR(9),
    `cpf` CHAR(11),
    `cnh` CHAR(11),
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
    CONSTRAINT `fk_usuario` FOREIGN KEY (`usuario`) REFERENCES `usuario`(`id`),
    CONSTRAINT `fk_modulo` FOREIGN KEY (`modulo`) REFERENCES `modulo`(`id`)
)ENGINE = InnoDB;

--
-- Criação de Permissões automática --
--
DROP TRIGGER IF EXISTS `AI_Usuario_Permissoes`;
DELIMITER $$
CREATE TRIGGER `AI_Usuario_Permissoes` 
AFTER INSERT ON `usuario` FOR EACH ROW
BEGIN
	CALL `AdcPermissoes` (new.id,'M');
END $$
DELIMITER ;

DROP TRIGGER IF EXISTS `AI_Modulo_Permissoes`;
DELIMITER $$
CREATE TRIGGER `AI_Modulo_Permissoes` 
AFTER INSERT ON `modulo` FOR EACH ROW
BEGIN
	CALL `AdcPermissoes` (new.id,'U');
END $$
DELIMITER ;

DROP TRIGGER IF EXISTS `BD_Usuario_Permissoes`;
DELIMITER $$
CREATE TRIGGER `BD_Usuario_Permissoes` 
BEFORE DELETE ON `usuario` FOR EACH ROW
BEGIN
	DELETE FROM `permissao` WHERE `usuario` = old.id;
END $$
DELIMITER ;

DROP TRIGGER IF EXISTS `BD_Modulo_Permissoes`;
DELIMITER $$
CREATE TRIGGER `BD_Modulo_Permissoes` 
BEFORE DELETE ON `modulo` FOR EACH ROW
BEGIN
	DELETE FROM `permissao` WHERE `modulo` = old.id;
END $$
DELIMITER ;


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
-- Fim da Permissao automática







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