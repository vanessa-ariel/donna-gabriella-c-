CREATE DATABASE DonnaGabriela

USE DonnaGabriela

CREATE TABLE Usuario (
	ID_User INT IDENTITY(1,1) PRIMARY KEY,
	Senha_User VARCHAR(200),
	Nome_User VARCHAR(50),
	CPF_User VARCHAR(17),
	Telefone_user VARCHAR(17),
	Email_User VARCHAR(120),
	Endereco_User VARCHAR(250),
	Numero_User VARCHAR(10),
	Complemento_User VARCHAR(100),
	Cep_User VARCHAR(10),
	Data_Nasci_User DATE,
	Sexo_User VARCHAR(20),
	Data_Cadastro DATE,
	Data_Desligamento DATE,
	Status_Conta VARCHAR(1),
)

CREATE TABLE Voluntario (
    ID_Voluntario INT IDENTITY(1,1) PRIMARY KEY,
	ID_Servico varchar(10),

	Nome_Servico varchar(100),
	Nome_Voluntario VARCHAR(150),
	Telefone_Voluntario VARCHAR(50),
	Email_Voluntario VARCHAR(50),

	Cep_Voluntario VARCHAR(9),
	Endereco_Voluntario VARCHAR(250),
	Numero_Voluntario VARCHAR(20),
	Bairro_Voluntario VARCHAR(150),
	Cidade_Voluntario VARCHAR(150),
	Complemento_Voluntario VARCHAR(100),

	Data_Nasci_Voluntario VARCHAR(10),

	Senha_Voluntario VARCHAR(25),

	Data_Cadastro VARCHAR(10),
	Data_Admissao VARCHAR(10),
	Data_Desligamento VARCHAR(10),
	Status_Conta VARCHAR(1),
)

INSERT INTO Usuario 
( 
	Senha_User, 
	Nome_User, 
	CPF_User, 
	Telefone_User, 
	Endereco_User, 
	Numero_User, 
	Complemento_User, 
	Cep_User, 
	Data_Nasci_User, 
	Sexo_User,
	Data_Cadastro,
	Data_Desligamento,
	Status_Conta
) VALUES 
(
	'123', 
	'Rodrigo Junior', 
	'35011829880',
	'232323231',
	'rodrigojunior0323@gmail.com', 
	'Rua teste', 
	'24', 
	'1234', 
	'2020-05-17', 
	'Masculino', 
	'2020-05-17',
	'',
	'0'
)

INSERT INTO Voluntario (
	ID_Servico,
	Nome_Servico,
	Nome_Voluntario,
	Telefone_Voluntario,
	Email_Voluntario,
	Cep_Voluntario,
	Endereco_Voluntario,
	Numero_Voluntario,
	Bairro_Voluntario,
	Cidade_Voluntario,
	Complemento_Voluntario,
	Data_Nasci_User,
	Senha_Voluntario,
	Sexo_Voluntario,
	Data_Cadastro,
	Data_Desligamento,
	Data_Admissao,
	Status_Conta,
	CPF_Voluntario
) VALUES(
	123,
	'Psicologico',
	'Voluntaria 01',
	'1199999 99999',
	'voluntaria01@email.com',
	'99999-999',
	'Rua da Voluntaria 01',
	'1001',
	'Centro',
	'Sao Paulo',
	'Apto 1001',
	'10/05/2022',
	'1234563',
	'F',
	'20/05/2022',
	'',
	'',
	0,
	'99999999999'),
	(
	123,
	'Psicologico',
	'Voluntaria 01',
	'1199999 99999',
	'voluntaria01@email.com',
	'99999-999',
	'Rua da Voluntaria 01',
	'1001',
	'Centro',
	'Sao Paulo',
	'Apto 1001',
	'10/05/2022',
	'1234563',
	'F',
	'20/05/2022',
	'',
	'',
	0,
	'99999999999'),
	(
	123,
	'Psicologico',
	'Voluntaria 01',
	'1199999 99999',
	'voluntaria01@email.com',
	'99999-999',
	'Rua da Voluntaria 01',
	'1001',
	'Centro',
	'Sao Paulo',
	'Apto 1001',
	'10/05/2022',
	'1234563',
	'F',
	'20/05/2022',
	'',
	'',
	0,
	'99999999999')



SELECT * FROM Voluntario

SELECT Nome_User, CPF_User, Email_User FROM Usuario WHERE Status_Conta = 0;
SELECT COUNT(ID_user) AS 'Usuarios Ativos' FROM Usuario;

SELECT ID_Voluntario, Nome_Voluntario, Telefone_Voluntario FROM Voluntario WHERE Status_Conta = 'ativo';
SELECT ID_Voluntario, Nome_Voluntario, Telefone_Voluntario FROM Voluntario WHERE Status_Conta = 'pendente';

/*general queries*/
use master
drop database DonnaGabriela

