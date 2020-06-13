DELIMITER $$
CREATE PROCEDURE `AddOrEditTecnico` ( 
	_id INT, 
    _nome VARCHAR(45), 
    _nasc DATE, 
    _sexo SET('Feminino','Masculino','Outro'),
    _rg CHAR(9),
    _cpf CHAR(11),
    _cnh CHAR(11)
)
BEGIN
	IF (_id > 1 ) THEN
		INSERT INTO `tecnico` VALUES (0,_nome,_nasc,_sexo,_rg,_cpf,_cnh);
	ELSE
		UPDATE `tecnico` SET `nome`=_nome,``=_nasc,`sexo`=_sexo,`rg`=_rg,`cpf`=_cpf,`cnh`=_cnh WHERE `codTecnico`=_id;
	END IF;
END $$
DELIMITER ;