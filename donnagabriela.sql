CREATE DATABASE DonnaGabriela

USE DonnaGabriela

/*TABLES*/

CREATE TABLE Cargo(
	ID_Cargo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome_Cargo VARCHAR(50) NOT NULL,
	Status_Cargo CHAR(1) NOT NULL,
)

CREATE TABLE Departamento(
	ID_Depto INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome_Depto VARCHAR(50) NOT NULL,
	Status_Depto CHAR(1) NOT NULL,
)

CREATE TABLE Usuario (
	ID_User INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome_User VARCHAR(50) NOT NULL,
	CPF_User VARCHAR(14) NOT NULL,
	Telefone_User VARCHAR(19) NOT NULL,
	Email_User VARCHAR(120) NOT NULL,
	Data_Nasci_User VARCHAR(10) NOT NULL,

	Cep_User VARCHAR(9) NOT NULL,
	Endereco_User VARCHAR(250) NOT NULL,
	Numero_User VARCHAR(10) NOT NULL,
	Complemento_User VARCHAR(100) NOT NULL,
	Bairro_User VARCHAR(150) NOT NULL,
	Cidade_User VARCHAR(150) NOT NULL,

	Data_Cadastro VARCHAR(10) NOT NULL,
	Senha_User VARCHAR(25) NOT NULL,
	Recuperar_Senha VARCHAR(255),
	Status_Conta CHAR(1) NOT NULL,
)

CREATE TABLE Voluntario (
    ID_Voluntario INT IDENTITY(1,1) PRIMARY KEY,
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
	Recuperar_Senha VARCHAR(255),
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

CREATE TABLE Servico (
	ID_Servico INT IDENTITY(1,1) PRIMARY KEY,
	ID_Voluntario INT FOREIGN KEY REFERENCES Voluntario(ID_Voluntario),
	Nome_Servico VARCHAR(100),
	Dia_Disponivel DATE,
	Horario_Inicio DATETIME,
	Horario_Termino DATETIME,
	Status_Servico CHAR(1)
)

CREATE TABLE Servico_Solicitado (
	ID_Serv_Solicitado INT IDENTITY(1,1) PRIMARY KEY,
	ID_User INT FOREIGN KEY REFERENCES Usuario(ID_User),
	ID_Voluntario INT FOREIGN KEY REFERENCES Voluntario(ID_Voluntario),
	Data_Solicitacao DATETIME,
	Data_Inicio DATETIME,
	Data_Termino DATETIME,
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
	Status_Conta,
	Senha_User,
	Recuperar_Senha
) 
VALUES (
	'Lilian Alves Hall', 
	'414.774.318-88', 
	'(12) 98171-4569', 
	'lilian.hall@email.com.br', 
	'Rua Ushi Teruya', 
	'219', 
	'', 
	'Parque São Vicente',
	'São Paulo',
	'09371-066', 
	'21/05/2000', 
	'10/09/2021',
	0, 
	123456,
	''
),
(
	'Eva Vasconcelos Sodre', 
	'534.561.447-41', 
	'(21) 99501-9101', 
	'eva.sodre@email.com.br', 
	'Rua Paulo Pessoa', 
	'576', 
	'Apto 34', 
	'Rua Paulo Pessoa',
	'São Paulo',
	'09371-066', 
	'03/08/1990', 
	'10/09/2021',
	0, 
	123456,
	''
),
(
	'Helena Fernandes Cordeiro', 
	'669.394.863-48', 
	'(86) 97531-5143', 
	'helena.fernandes.us@gmail.com', 
	'Rua Paulo Pessoa', 
	'3821', 
	'', 
	'Pedra Miúda',
	'São Paulo',
	'64038-451', 
	'03/08/1990', 
	'10/09/2021',
	0, 
	123456,
	''
),
(
	'Gilmara Gualberto Vasconcelos', 
	'438.899.632-77', 
	'(95) 99988-6671', 
	'gilmara.vasconcelos@email.com.br', 
	'Rua Dilmar Mesquita', 
	'103', 
	'', 
	'Caçari',
	'Boa Vista',
	'69307-690', 
	'03/12/1982', 
	'10/09/2021',
	0, 
	123456,
	''
),
(
	'Simone Gouveia Coelho', 
	'873.089.772-69', 
	'(68) 96717-2681', 
	'simone.coelho@email.com.br', 
	'Rua Padre Paulino', 
	'218', 
	'', 
	'Conjunto Rui Lino',
	'Rio Branco',
	'69919-830', 
	'11/04/1999', 
	'10/09/2021',
	1, 
	123456,
	''
),
(
	'Gabriela Morais Latin', 
	'243.783.864-37', 
	'(84) 98022-3461', 
	'gabriela.latin@email.com.br', 
	'Rua José do Patrocínio', 
	'34', 
	'', 
	'Candelária',
	'Natal',
	'59065-210', 
	'18/07/1989', 
	'10/09/2021',
	1, 
	123456,
	''
),
(
	'Kamila Bonimo Fernando', 
	'579.475.689-60', 
	'(47) 97628-6140', 
	'kamila.fernando@email.com.br', 
	'Rua Procurador Abelardo Gomes', 
	'764', 
	'', 
	'Centro',
	'Florianópolis',
	'88010-240', 
	'18/07/1989', 
	'10/09/2021',
	1, 
	123456,
	''
),
(
	'Lina Prata Pacheco', 
	'431.255.372-66', 
	'(92) 98624-5674', 
	'lina.pacheco@email.com.br', 
	'Rua Doutor Alfredo Sá', 
	'451', 
	'', 
	'Redenção',
	'Manaus',
	'69047-741', 
	'17/08/1983', 
	'10/09/2021',
	1, 
	123456,
	''
),
(
	'Stephania Stutz Rezende', 
	'405.142.089-29', 
	'(44) 98110-8674', 
	'stephania.rezende@email.com.br', 
	'Rua Francisca Pires', 
	'936', 
	'', 
	'Pinheirinho',
	'Francisco Beltrão',
	'85603-585', 
	'05/02/1997', 
	'10/09/2021',
	1, 
	123456,
	''
),
(
	'Nathalia Sousa Belmiro', 
	'425.857.358-26', 
	'(12) 98642-2773', 
	'nathalia.belmiro@email.com.br', 
	'Rua do Bosque', 
	'576', 
	'', 
	'Vila Progresso',
	'Salto',
	'13321-192', 
	'26/12/1983', 
	'10/09/2021',
	1, 
	123456,
	''
)

INSERT INTO Voluntario (
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
	Senha_Voluntario,
    Recuperar_Senha
)VALUES 
(
	'Psicologico',
	'Julia Melissa Luiza Nogueira',
	'356.697.548-67',
	'(19) 99104-0743',
	'julia.melissa.vol@gmail.com',
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
	'123456',
    ''
),
(
	'Assistencia Social',
	'Sabrina Yasmin Maya Silveira',
	'112.756.778-00',
	'(11) 98176-6360',
	'sabrina_silveira@email.com.br',
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
	'123456',
    ''
),
(
	'Jurídico',
	'Luciana Ester Rosa Souza',
	'422.864.078-86',
	'(11) 99680-3093',
	'lucianaestersouza@email.com.br',
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
	'123456',
    ''
),
(
	'Psicologico',
	'Isadora Jennifer Sarah da Cruz',
	'147.922.868-08',
	'12 98765 8743',
	'isadora.j@email.com.br',
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
	'123456',
    ''
),
(
	'Assistencia Social',
	'Antonella Evelyn Amanda Vieira',
	'956.437.018-39',
	'(13) 98739-6887',
	'antonella_vieira@email.com.br',
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
	'123456',
    ''
),
(
	'Jurídico',
	'Maya Joana Porto',
	'058.873.368-70',
	'(11) 99275-8777',
	'mayajoanaporto@email.com.br',
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
	'123456',
    ''
),
(
	'Psicologico',
	'Alessandra Elisa Barros',
	'197.038.508-12',
	'(11) 99852-4675',
	'alebarros@email.com.br',
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
	'123456',
    ''
),
(
	'Assistencia Social',
	'Maria Renata Aragão',
	'266.195.968-86',
	'(14) 99528-6433',
	'mariarenata@email.com.br',
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
	'123456',
    ''
),
(
	'Jurídico',
	'Yasmin Lara Isis Sales',
	'730.683.568-81',
	'12 98765 8743',
	'yasminsales@email.com.br',
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
	'123456',
    ''
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
	'743.844.098-26',
	'13.900.416-6',
	'(19) 99638-4706',
	'rodrigo@email.com',
	'Rua Plínio de Campos',
	'554',
	'',
	'Jardim Maracanã',
	'São Paulo',
	'13034-595',
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
	'025.210.608-36',
	'23.866.882-4',
	'(19) 98657-9863',
	'vanessa@email.com',
	'Avenida 22 JC',
	'125',
	'',
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
	'384.212.538-08',
	'13.105.077-1',
	'(11) 98778-7459',
	'pedro@email.com',
	'Rua Oduvaldo Viana Filho',
	'802',
	'',
	'Vila Palmares',
	'São Paulo',
	'09060-875',
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
	'505.590.258-23',
	'32.960.996-8',
	'(17) 99133-2174',
	'lilian@email.com',
	'Rua Chirala Abrahão',
	'753',
	'',
	'Jardim Vale do Sol',
	'São Paulo',
	'15045-100',
	'21/02/1990',
	'01/10/2010',
	'',
	1,
	'123456'
)

INSERT INTO Servico(ID_Voluntario, Nome_Servico, Dia_Disponivel, Horario_Inicio, Horario_Termino, Status_Servico) 
	VALUES 
	(1, 'Psicológico', GetDate(), GetDate(), GetDate(), 1), 
	(2, 'Assistência social', GetDate(), GetDate(), GetDate(), 1)

INSERT INTO Servico_Solicitado(ID_User, ID_Voluntario, Data_Solicitacao, Data_Inicio, Data_Termino) VALUES(1, 1, 2022-05-01, 2022-06-01, NULL), 
(2, 2, 2022-01-01, 2022-06-19, NULL), (3, 3, 2022-03-10, 2022-06-02, NULL)

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

