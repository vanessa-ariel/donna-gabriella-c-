CREATE DATABASE DonnaGabriela

USE DonnaGabriela

/*TABLES*/

CREATE TABLE Cargo(
	ID_Cargo INT IDENTITY(1,1) PRIMARY KEY,
	Nome_Cargo VARCHAR(50),
	Status_Cargo CHAR(1),
)

CREATE TABLE Departamento(
	ID_Depto INT IDENTITY(1,1) PRIMARY KEY,
	Nome_Depto VARCHAR(50),
	Status_Depto CHAR(1),
)

CREATE TABLE Usuario (
	ID_User INT IDENTITY(1,1) PRIMARY KEY,
	Nome_User VARCHAR(50),
	CPF_User VARCHAR(14),
	Telefone_User VARCHAR(19),
	Email_User VARCHAR(120),

	Endereco_User VARCHAR(250),
	Numero_User VARCHAR(10),
	Complemento_User VARCHAR(100),
	Bairro_User VARCHAR(150),
	Cidade_User VARCHAR(150),
	Cep_User VARCHAR(9),

	Data_Nasci_User VARCHAR(10),
	Data_Cadastro VARCHAR(10),
	Data_Admissao VARCHAR(10),
	Data_Desligamento VARCHAR(10),
	Status_Conta CHAR(1),

	Senha_User VARCHAR(25),
)

CREATE TABLE Voluntario (
    ID_Voluntario INT IDENTITY(1,1) PRIMARY KEY,
	ID_Servico varchar(10),

	Nome_Servico varchar(100),
	Nome_Voluntario VARCHAR(150),
	CPF_Voluntario VARCHAR(14),
	Telefone_Voluntario VARCHAR(19),
	Email_Voluntario VARCHAR(120),

	Endereco_Voluntario VARCHAR(250),
	Numero_Voluntario VARCHAR(10),
	Complemento_Voluntario VARCHAR(100),
	Bairro_Voluntario VARCHAR(150),
	Cidade_Voluntario VARCHAR(150),
	Cep_Voluntario VARCHAR(9),

	Data_Nasci_Voluntario VARCHAR(10),
	Data_Cadastro VARCHAR(10),
	Data_Admissao VARCHAR(10),
	Data_Desligamento VARCHAR(10),
	Status_Conta CHAR(1),

	Senha_Voluntario VARCHAR(25),
)

CREATE TABLE Funcionario (
	ID_Func INT IDENTITY(1,1) PRIMARY KEY,
	ID_Cargo INT FOREIGN KEY REFERENCES Cargo(ID_Cargo),
	ID_Depto INT FOREIGN KEY REFERENCES Departamento(ID_Depto),

	Nome_Func VARCHAR(50),
	CPF_Func VARCHAR(14),
	RG_Func VARCHAR(15),
	Telefone_Func VARCHAR(19),
	Email_Func VARCHAR(120),

	Endereco_Func VARCHAR(250),
	Numero_Func VARCHAR(10),
	Complemento_Func VARCHAR(100),
	Bairro_Func VARCHAR(150),
	Cidade_Func VARCHAR(150),
	Cep_Func VARCHAR(9),

	Data_Nasci_Func VARCHAR(10),
	Data_Admissao VARCHAR(10),
	Data_Desligamento VARCHAR(10),
	Status_Conta CHAR(1),

	Senha_User VARCHAR(25),
)

CREATE TABLE Servico(
	ID_Servico INT IDENTITY(1,1) PRIMARY KEY,
	Nome_Serviço VARCHAR(50),
	Duracao VARCHAR(5),
	Status_Servico CHAR(1)
)

CREATE TABLE Servico_Solicitado (
	ID_Serv_Solicitado INT IDENTITY(1,1) PRIMARY KEY,
	ID_Servico INT FOREIGN KEY REFERENCES Servico(ID_Servico),
	ID_User INT FOREIGN KEY REFERENCES Usuario(ID_User),
	ID_Voluntario INT FOREIGN KEY REFERENCES Voluntario(ID_Voluntario),
	Data_Solicitacao VARCHAR(10),
	Data_Inicio VARCHAR(10),
	Data_Termino VARCHAR(10),
	Hora_Solicitacao VARCHAR(5)
)

CREATE TABLE Suporte (
	ID_Suporte INT IDENTITY(1,1) PRIMARY KEY,
	Tipo_Suporte VARCHAR(50),
	Status_Suporte CHAR(1)
)

CREATE TABLE Suporte_Solicitado (
	ID_Sup_Solicitado INT IDENTITY(1,1) PRIMARY KEY,
	ID_Suporte INT FOREIGN KEY REFERENCES Suporte(ID_Suporte),
	ID_User INT FOREIGN KEY REFERENCES Usuario(ID_User),
	ID_Func INT FOREIGN KEY REFERENCES Funcionario(ID_Func),
	Data_Solicitacao VARCHAR(10),
	Data_Termino VARCHAR(10),
	Data_Inicio VARCHAR(10),
	Status_Sup_Solicitado CHAR(1)
)


/*INSERTS START HERE*/
INSERT INTO Cargo (Nome_Cargo,Status_Cargo) VALUES ('Programador Web','1'),('Programador Desk','1'),('Programador Mobile','1'),('Product Owner','1'),('Scrum Master','1')

INSERT INTO Departamento (Nome_Depto,Status_Depto) VALUES ('Tecnologia', '1'), ('Marketing', '1'), ('RH', '1'), ('Finanças', '1')

INSERT INTO Usuario (
	Nome_User,
	CPF_User,
	Telefone_user,
	Email_User,
	Endereco_User,
	Numero_User,
	Complemento_User,
	Bairro_User,
	Cidade_User,
	Cep_User,
	Data_Nasci_User,
	Data_Cadastro,
	Data_Admissao,
	Data_Desligamento,
	Status_Conta,
	Senha_User
) 
VALUES (
	'Fernanda da Silva', 
	'404.749.450-06', 
	'11 98374 6253', 
	'mariasilvaa@email.com', 
	'Rua Lorem Ipsum', 
	'29', 
	'Apto 2', 
	'Jardim Europa',
	'São Paulo',
	'02938-928', 
	'21/05/2000', 
	'21/05/2000',
	'11/01/2022',
	'02/04/2022',
	0, 
	123456
),
(
	'Bruna', 
	'404.749.450-06', 
	'11 98374 6253', 
	'mariasilvaa@email.com', 
	'Rua Lorem Ipsum', 
	'29', 
	'Apto 2', 
	'Jardim Europa',
	'São Paulo',
	'02938-928', 
	'21/05/2000',
	'21/05/2000',
	'11/01/2022',
	'02/04/2022',
	1, 
	123456
),
(
	'Andressa', 
	'404.749.450-06', 
	'11 98374 6253', 
	'mariasilvaa@email.com', 
	'Rua Lorem Ipsum', 
	'29', 
	'Apto 2', 
	'Jardim Europa',
	'São Paulo',
	'02938-928', 
	'21/05/2000', 
	'21/05/2000',
	'11/01/2022',
	'02/04/2022',
	2, 
	123456
)

INSERT INTO Voluntario (
	ID_Servico,
	Nome_Servico,
	Nome_Voluntario,
	CPF_Voluntario,
	Telefone_Voluntario,
	Email_Voluntario,
	Endereco_Voluntario,
	Numero_Voluntario,
	Complemento_Voluntario,
	Bairro_Voluntario,
	Cidade_Voluntario,
	Cep_Voluntario,
	Data_Nasci_Voluntario,
	Data_Cadastro,
	Data_Admissao,
	Data_Desligamento,
	Status_Conta,
	Senha_Voluntario
)VALUES 
(
	1,
	'Psicologico',
	'Voluntaria Lilian',
	'665.452.160-90',
	'12 98765 8743',
	'lilian@email.com',
	'Rua Lorem Ipsum',
	'200',
	'Apto 101',
	'Centro',
	'São Paulo',
	'54323-098',
	'28/03/2001',
	'03/10/2021',
	'05/04/2022',
	'10/05/2022',
	1,
	'123456'
),
(
	2,
	'Assistencia Social',
	'Voluntaria Lilian',
	'665.452.160-90',
	'12 98765 8743',
	'lilian@email.com',
	'Rua Lorem Ipsum',
	'200',
	'Apto 101',
	'Centro',
	'São Paulo',
	'54323-098',
	'28/03/2001',
	'03/10/2021',
	'05/04/2022',
	'10/05/2022',
	0,
	'123456'
),
(
	3,
	'Jurídico',
	'Voluntaria Lilian',
	'665.452.160-90',
	'12 98765 8743',
	'lilian@email.com',
	'Rua Lorem Ipsum',
	'200',
	'Apto 101',
	'Centro',
	'São Paulo',
	'54323-098',
	'28/03/2001',
	'03/10/2021',
	'05/04/2022',
	'10/05/2022',
	2,
	'123456'
)

INSERT INTO Funcionario (
	ID_Cargo,
	ID_Depto,
	Nome_Func,
	CPF_Func,
	RG_Func,
	Telefone_Func,
	Email_Func,
	Endereco_Func,
	Numero_Func,
	Complemento_Func,
	Bairro_Func,
	Cidade_Func,
	Cep_Func,
	Data_Nasci_Func,
	Data_Admissao,
	Data_Desligamento,
	Status_Conta,
	Senha_User
) VALUES (
	1,
	1,
	'Rodrigo Junior',
	'369.049.890-25',
	'235643221',
	'19948762345',
	'rodrigo@email.com',
	'Rua Lorem Ipsum',
	'1',
	'Bloco B',
	'Centro',
	'São Paulo',
	'02746-584',
	'21/02/1990',
	'01/10/2010',
	'',
	1,
	'123456'
),
(
	2,
	1,
	'Vanessa Ariel',
	'369.049.890-25',
	'235643221',
	'19948762345',
	'vanessa@email.com',
	'Rua Lorem Ipsum',
	'1',
	'Bloco B',
	'Centro',
	'São Paulo',
	'02746-584',
	'21/02/1990',
	'01/10/2010',
	'',
	1,
	'123456'
),
(
	3,
	1,
	'Pedro Martins',
	'369.049.890-25',
	'235643221',
	'19948762345',
	'pedro@email.com',
	'Rua Lorem Ipsum',
	'1',
	'Bloco B',
	'Centro',
	'São Paulo',
	'02746-584',
	'21/02/1990',
	'01/10/2010',
	'',
	1,
	'123456'
),
(
	4,
	1,
	'Lilian Cabral',
	'369.049.890-25',
	'235643221',
	'19948762345',
	'lilian@email.com',
	'Rua Lorem Ipsum',
	'1',
	'Bloco B',
	'Centro',
	'São Paulo',
	'02746-584',
	'21/02/1990',
	'01/10/2010',
	'',
	1,
	'123456'
)

INSERT INTO Servico(Nome_Serviço,Duracao, Status_Servico) VALUES ('Atendimento Psicológico', '01:00', 1),('Assistência Social', '01:00', 1),('Atendimento Jurídico', '01:00', 1);

INSERT INTO Servico_Solicitado(ID_Servico, ID_User, ID_Voluntario, Data_Solicitacao, Data_Inicio, Data_Termino, Hora_Solicitacao) VALUES(1, 1, 1, '01/01/2022', '10/01/2022', NULL, '10:00'), 
(2, 2, 2, '01/01/2022', '10/01/2022', NULL, '12:00'), (3, 3, 3, '01/01/2022', '10/01/2022', NULL, '13:00')

/*
ID SERVICO: 
1 - PSICOLÓGICO
2 - ASSISTÊNCIA SOCIAL
3 - JURÍDICO

STATUS CONTA
0 - PENDENTE
1 - ATIVO
2 - INATIVO

ID CARGO
1 - Programador Web
2 - Programador Desk
3 - Programador Mobile
4 - Product Owner
5 - UI Designer


ID DEPTO
1 - Tecnologia
2 - Marketing
3 - RH
4 - Finanças
*/



/*general queries*/
use master
drop database DonnaGabriela
SELECT Nome_User, CPF_User, Email_User FROM Usuario WHERE Status_Conta = 0;

SELECT * FROM Cargo
SELECT * FROM Departamento
SELECT * FROM Usuario
SELECT * FROM Voluntario
SELECT * FROM Funcionario
SELECT * FROM Servico
SELECT * FROM Servico_Solicitado
SELECT * FROM Suporte
SELECT * FROM Suporte_Solicitado
