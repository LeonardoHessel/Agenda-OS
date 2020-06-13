CREATE DATABASE `agenda`;
USE `agenda`;

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario`(
	`id` INT PRIMARY KEY AUTO_INCREMENT,
    `login` VARCHAR(45) NOT NULL,
    `senha` VARCHAR(45) NOT NULL,
    `nome` VARCHAR(45),
    `nasc` DATE,
    `sexo` SET('Feminino','Masculino','Outro'),
    `rg` CHAR(9),
    `cpf` CHAR(11),
    `cnh` CHAR(11),
    `del` BOOL
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `modulo`;
CREATE TABLE IF NOT EXISTS `modulo`(
	`id` INT PRIMARY KEY AUTO_INCREMENT,
    `grupo` VARCHAR(20),
    `descricao` VARCHAR(50),
    `restricao` BOOL
)ENGINE = InnoDB;

DROP TABLE IF EXISTS `permissao`;
CREATE TABLE IF NOT EXISTS `permissao`(
	`usuario` INT,
    `modulo` INT,
    `acesso` BOOL,
    PRIMARY KEY(`usuario`,`modulo`),
    CONSTRAINT `fk_usuario` FOREIGN KEY (`usuario`) REFERENCES `usuario`(`id`),
    CONSTRAINT `fk_modulo` FOREIGN KEY (`modulo`) REFERENCES `modulo`(`id`)
)ENGINE = InnoDB;

#Criar trigger apos a insert de usuario, chamar uma procedire que pega todos os modulos insere uma permissçao para cada modulo com id do usuario e permisao = true.













/*
DROP TABLE IF EXISTS ``;
CREATE TABLE IF NOT EXISTS ``(
	
)ENGINE = InnoDB;
*/