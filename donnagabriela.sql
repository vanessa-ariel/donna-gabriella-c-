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

	Senha_Func VARCHAR(25),
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
	'Lilian Barsosa Hall', 
	'414.774.318-88', 
	'(12) 98171-4569', 
	'lilian.hall@geradornv.com.br', 
	'Rua Ushi Teruya', 
	'219', 
	'', 
	'Parque São Vicente',
	'São Paulo',
	'09371-066', 
	'21/05/2000', 
	'10/09/2021',
	'12/09/2021',
	'',
	0, 
	123456
),
(
	'Eva Vasconcelos Sodre', 
	'534.561.447-41', 
	'(21) 99501-9101', 
	'eva.sodre@geradornv.com.br', 
	'Rua Paulo Pessoa', 
	'576', 
	'Apto 34', 
	'Rua Paulo Pessoa',
	'São Paulo',
	'09371-066', 
	'03/08/1990', 
	'10/09/2021',
	'12/09/2021',
	'',
	0, 
	123456
),
(
	'Helena Nigro Cordeiro', 
	'669.394.863-48', 
	'(86) 97531-5143', 
	'helena.cordeiro@geradornv.com.br', 
	'Rua Paulo Pessoa', 
	'3821', 
	'', 
	'Pedra Miúda',
	'São Paulo',
	'64038-451', 
	'03/08/1990', 
	'10/09/2021',
	'12/09/2021',
	'',
	0, 
	123456
),
(
	'Gilmara Gualberto Vasconcelos', 
	'438.899.632-77', 
	'(95) 99988-6671', 
	'gilmara.vasconcelos@geradornv.com.br', 
	'Rua Dilmar Mesquita', 
	'103', 
	'', 
	'Caçari',
	'Boa Vista',
	'69307-690', 
	'03/12/1982', 
	'10/09/2021',
	'12/09/2021',
	'',
	0, 
	123456
),
(
	'Simone Gouveia Coelho', 
	'873.089.772-69', 
	'(68) 96717-2681', 
	'simone.coelho@geradornv.com.br', 
	'Rua Padre Paulino', 
	'218', 
	'', 
	'Conjunto Rui Lino',
	'Rio Branco',
	'69919-830', 
	'11/04/1999', 
	'10/09/2021',
	'12/09/2021',
	'',
	1, 
	123456
),
(
	'Gabriela Morais Latin', 
	'243.783.864-37', 
	'(84) 98022-3461', 
	'gabriela.latin@geradornv.com.br', 
	'Rua José do Patrocínio', 
	'34', 
	'', 
	'Candelária',
	'Natal',
	'59065-210', 
	'18/07/1989', 
	'10/09/2021',
	'12/09/2021',
	'',
	1, 
	123456
),
(
	'Kamila Bonimo Fernando', 
	'579.475.689-60', 
	'(47) 97628-6140', 
	'kamila.fernando@geradornv.com.br', 
	'Rua Procurador Abelardo Gomes', 
	'764', 
	'', 
	'Centro',
	'Florianópolis',
	'88010-240', 
	'18/07/1989', 
	'10/09/2021',
	'12/09/2021',
	'',
	1, 
	123456
),
(
	'Lina Prata Pacheco', 
	'431.255.372-66', 
	'(92) 98624-5674', 
	'lina.pacheco@geradornv.com.br', 
	'Rua Doutor Alfredo Sá', 
	'451', 
	'', 
	'Redenção',
	'Manaus',
	'69047-741', 
	'17/08/1983', 
	'10/09/2021',
	'12/09/2021',
	'',
	1, 
	123456
),
(
	'Stephania Stutz Rezende', 
	'405.142.089-29', 
	'(44) 98110-8674', 
	'stephania.rezende@geradornv.com.br', 
	'Rua Francisca Pires', 
	'936', 
	'', 
	'Pinheirinho',
	'Francisco Beltrão',
	'85603-585', 
	'05/02/1997', 
	'10/09/2021',
	'12/09/2021',
	'',
	1, 
	123456
),
(
	'Nathalia Sousa Belmiro', 
	'425.857.358-26', 
	'(12) 98642-2773', 
	'nathalia.belmiro@geradornv.com.br', 
	'Rua do Bosque', 
	'576', 
	'', 
	'Vila Progresso',
	'Salto',
	'13321-192', 
	'26/12/1983', 
	'10/09/2021',
	'12/09/2021',
	'',
	1, 
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
	'Julia Melissa Luiza Nogueira',
	'356.697.548-67',
	'(19) 99104-0743',
	'julia_nogueira@plani.com.br',
	'Rua 16',
	'963',
	'Apto 101',
	'Jardim Planalto',
	'Paulínia',
	'13145-161',
	'19/02/1985',
	'03/10/2021',
	'05/04/2022',
	'',
	0,
	'123456'
),
(
	2,
	'Assistencia Social',
	'Sabrina Yasmin Maya Silveira',
	'112.756.778-00',
	'(11) 98176-6360',
	'sabrina_silveira@dicid.com.br',
	'Rua Cidade de Limeira',
	'418',
	'',
	'Jardim Itaparica',
	'Barueri',
	'06447-080',
	'17/01/1996',
	'03/10/2021',
	'05/04/2022',
	'',
	0,
	'123456'
),
(
	3,
	'Jurídico',
	'Luciana Ester Rosa Souza',
	'422.864.078-86',
	'(11) 99680-3093',
	'lucianaestersouza@alanamaral.com.br',
	'Praça Maria da Penha Nascimento e Silva',
	'155',
	'Apto 101',
	'Mooca',
	'São Paulo',
	'03155-015',
	'08/03/1990',
	'03/10/2021',
	'05/04/2022',
	'',
	0,
	'123456'
),
(
	1,
	'Psicologico',
	'Isadora Jennifer Sarah da Cruz',
	'147.922.868-08',
	'12 98765 8743',
	'isadora.j@prodam.am.gov.br',
	'Avenida Astério Genário',
	'357',
	'',
	'Mirim',
	'Praia Grande',
	'11705-050',
	'11/05/1998',
	'03/10/2021',
	'05/04/2022',
	'',
	0,
	'123456'
),
(
	2,
	'Assistencia Social',
	'Antonella Evelyn Amanda Vieira',
	'956.437.018-39',
	'(13) 98739-6887',
	'antonella_vieira@br.atlascopco.com',
	'Rua Projetada B',
	'835',
	'',
	'Balneário Cidade Atlântica',
	'Guarujá',
	'54323-098',
	'28/03/2001',
	'16/02/1992',
	'05/04/2022',
	'',
	0,
	'123456'
),
(
	3,
	'Jurídico',
	'Maya Joana Porto',
	'058.873.368-70',
	'(11) 99275-8777',
	'mayajoanaporto@segplanet.com.br',
	'Rua Tereza Breda Marson',
	'567',
	'',
	'Assunção',
	'São Bernardo do Campo',
	'09812-480',
	'02/03/2002',
	'03/10/2021',
	'05/04/2022',
	'',
	1,
	'123456'
),
(
	1,
	'Psicologico',
	'Alessandra Elisa Barros',
	'197.038.508-12',
	'(11) 99852-4675',
	'alessandra_barros@dprf.gov.br',
	'Rua Eduardo Batista Erbster',
	'948',
	'Apto 101',
	'Picanço',
	'Guarulhos',
	'07097-110',
	'28/03/2001',
	'03/10/2021',
	'05/04/2022',
	'',
	1,
	'123456'
),
(
	2,
	'Assistencia Social',
	'Maria Renata Aragão',
	'266.195.968-86',
	'(14) 99528-6433',
	'maria_renata_aragao@embraer.com.br',
	'Rua Félix Capinzaiki',
	'867',
	'Apto 101',
	'Jardim Olímpia',
	'Jaú',
	'17208-600',
	'27/02/2001',
	'03/10/2021',
	'05/04/2022',
	'',
	1,
	'123456'
),
(
	3,
	'Jurídico',
	'Yasmin Lara Isis Sales',
	'730.683.568-81',
	'12 98765 8743',
	'yasmin_sales@fileno.com.br',
	'Rua General Tibúrcio',
	'829',
	'Apto 101',
	'Rebouças',
	'São Paulo',
	'54323-098',
	'02/06/1988',
	'03/10/2021',
	'05/04/2022',
	'',
	1,
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
	Senha_Func
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

SELECT * FROM Cargo
SELECT * FROM Departamento
SELECT * FROM Usuario
SELECT * FROM Voluntario
SELECT * FROM Funcionario
SELECT * FROM Servico
SELECT * FROM Servico_Solicitado
SELECT * FROM Suporte
SELECT * FROM Suporte_Solicitado