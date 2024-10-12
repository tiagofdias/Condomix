--use [C:\USERS\UTILIZADOR\DESKTOP\CONDOMIX - GESTÃO DE CONDOMÍNIOS\CONDOMIX - GESTÃO DE CONDOMÍNIOS\CONDOMIX.MDF];

--CREATE TABLE Moradas (
--    IDMorada     INT     IDENTITY (1, 1) NOT NULL,
--    Morada       VARCHAR (300) NULL,
--    Localidade   VARCHAR (200) NULL,
--    CodigoPostal VARCHAR (8)   NULL,
--    PRIMARY KEY CLUSTERED (IDMorada ASC)
--);

--CREATE TABLE Contactos (
--    IDContacto          INT           IDENTITY (1, 1) NOT NULL,
--    Email               VARCHAR (100) NULL,
--    Contacto            INT           NULL,
--    ContactoAlternativo INT           NULL,
--    PRIMARY KEY CLUSTERED ([IDContacto] ASC)
--);


--Create table Clientes(
--	  IDCliente        INT          IDENTITY (1, 1) NOT NULL,
--    NIFCliente       INT          NOT NULL,
--    IDContacto       INT          NOT NULL,
--    IDBanco          INT          NOT NULL,
--    Nome             VARCHAR(300) NOT NULL, 
--    IBAN             VARCHAR (50) NOT NULL,

--    PRIMARY KEY CLUSTERED (IDCliente  ASC),
--    CONSTRAINT [FK_IDContacto2] FOREIGN KEY (IDContacto) REFERENCES Contactos (IDContacto) ON DELETE CASCADE ON UPDATE CASCADE,
--    CONSTRAINT [FK_IDBanco2] FOREIGN KEY (IDBanco) REFERENCES Bancos (IDBanco)

--);

--CREATE TABLE Bancos (
--    IDBanco INT           IDENTITY (1, 1) NOT NULL,
--    Nome    VARCHAR (200) NOT NULL,
--    Prefixo VARCHAR (10)  NOT NULL,
--    PRIMARY KEY CLUSTERED (IDBanco ASC)
--);

--CREATE TABLE Cargos (
--    IDCargo INT           IDENTITY (1, 1) NOT NULL,
--    Cargo   VARCHAR (100) NOT NULL,
--    PRIMARY KEY CLUSTERED (IDCargo ASC)
--);


--CREATE TABLE Funcionarios (
--	IDFuncionario  INT           IDENTITY (1, 1) NOT NULL,
--    NIFFuncionario INT           NOT NULL,
--    IDCargo        INT           NOT NULL,
--    IDContacto     INT           NOT NULL,
--	IDMorada       INT           NOT NULL,
--    Nome           VARCHAR (200) NOT NULL,
--    PRIMARY KEY CLUSTERED (IDFuncionario ASC),
--    CONSTRAINT [FK_IDCargo] FOREIGN KEY (IDCargo) REFERENCES Cargos (IDCargo),
--    CONSTRAINT [FK_IDContacto] FOREIGN KEY (IDContacto) REFERENCES Contactos (IDContacto) ON DELETE CASCADE ON UPDATE CASCADE,
--	CONSTRAINT [FK_Morada2] FOREIGN KEY (IDMorada) REFERENCES Moradas (IDMorada) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Condominios (
--    IDCondominio       INT          IDENTITY (1, 1) NOT NULL,
--    IDFuncionario      INT          NOT NULL,
--    IDMorada           INT          NOT NULL,
--    IDBanco            INT          NOT NULL,
--	Nome               VARCHAR(300) NOT NULL, 
--    OrcamentoAnual     DECIMAL (18) NOT NULL,
--    IBAN               VARCHAR (50) NOT NULL,
--    NumeroFracoes      INT          NULL,
--    NumeroAndares      INT          NULL,
--    NumeroLojas        INT          NULL,
--    NumeroGaragens     INT          NULL,
--    NumeroArrecadacoes INT          NULL,
--    NumeroElevadores   INT          NULL,
--    SalaCondominio     BIT          NULL,
--    PRIMARY KEY CLUSTERED (IDCondominio ASC),
--    CONSTRAINT [FK_IDBanco] FOREIGN KEY (IDBanco) REFERENCES Bancos (IDBanco),
--    CONSTRAINT [FK_IDFuncionario2] FOREIGN KEY (IDFuncionario) REFERENCES Funcionarios (IDFuncionario),
--    CONSTRAINT [FK_IDMorada] FOREIGN KEY (IDMorada) REFERENCES Moradas (IDMorada) ON DELETE CASCADE ON UPDATE CASCADE
--);



--Create table Fracoes(
--    IDFracao         INT          IDENTITY (1, 1) NOT NULL,
--    IDCondominio     INT          NOT NULL,
--    IDCliente        INT          NOT NULL,
--    NomeFracao       VARCHAR(300) NOT NULL, 
--	  TipoFracao       VARCHAR(300) NULL, 
--    Permilagem       DECIMAL NULL,
--	  QuotaMensal      DECIMAL NULL,
--	  AdministradorInterno BIT NOT NULL,
--	  Observacoes		VARCHAR(500) NULL, 

--    PRIMARY KEY CLUSTERED (IDFracao  ASC),
--    CONSTRAINT [FK_IDCondominio] FOREIGN KEY (IDCondominio) REFERENCES Condominios (IDCondominio),
--	  CONSTRAINT [FK_IDCliente] FOREIGN KEY (IDCliente) REFERENCES Clientes (IDCliente) 

--);

--CREATE TABLE Logins (
--    [IDLogin]        INT           IDENTITY (1, 1) NOT NULL,
--    [IDFuncionario]  INT           NOT NULL,
--    [Password]       VARCHAR (255) NOT NULL,
--    [Status]         BIT           NOT NULL,
--    PRIMARY KEY CLUSTERED ([IDLogin] ASC),
--    CONSTRAINT [FK_IDFuncionario] FOREIGN KEY (IDFuncionario) REFERENCES [dbo].[Funcionarios] (IDFuncionario) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Documentos (
--    IDDocumento INT             IDENTITY (1, 1) NOT NULL,
--    Documento   VARBINARY (MAX) NOT NULL,
--    Extensao    CHAR (4)        NOT NULL,
--    Nome        VARCHAR (100)   NOT NULL,
--    CONSTRAINT [PK_IDDocumento] PRIMARY KEY CLUSTERED (IDDocumento ASC)
--);

--CREATE TABLE [Atas] (
--    [IDAta]        INT           IDENTITY (1, 1) NOT NULL,
--    [IDCondominio] INT           NOT NULL,
--    [IDDocumento]  INT           NOT NULL,
--    [Nome]         VARCHAR (200) NOT NULL,
--    [Data]         AS            (CONVERT([date],getdate())),
--    PRIMARY KEY CLUSTERED ([IDAta] ASC),
--    CONSTRAINT [FK_IDCondominio2] FOREIGN KEY ([IDCondominio]) REFERENCES Condominios ([IDCondominio]),
--    CONSTRAINT [FK_IDDocumento] FOREIGN KEY (IDDocumento) REFERENCES Documentos (IDDocumento) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Ocorrencias (
--    IDOcorrencia        INT           IDENTITY (1, 1) NOT NULL,
--    IDCondominio        INT           NOT NULL,
--    IDFracao            INT           NOT NULL,
--	  IDFuncionario      INT           NOT NULL,
--	  IDDocumento         INT           NULL,
--    Titulo              VARCHAR (100) NOT NULL,
--    Descritivo          VARCHAR (300) NOT NULL,
--	  DataLimiteResolucao DATE NULL,
--	  Estado              VARCHAR (30) NOT NULL,
--    PRIMARY KEY CLUSTERED (IDOcorrencia ASC),
--    CONSTRAINT [FK_IDCondominio3] FOREIGN KEY ([IDCondominio]) REFERENCES Condominios ([IDCondominio]),
--	  CONSTRAINT [FK_IDFracao] FOREIGN KEY (IDFracao) REFERENCES Fracoes (IDFracao),
--	  CONSTRAINT [FK_IDFuncionario3] FOREIGN KEY (IDFuncionario) REFERENCES Funcionarios (IDFuncionario),
--    CONSTRAINT [FK_IDDocumento2] FOREIGN KEY (IDDocumento) REFERENCES Documentos (IDDocumento) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Vistorias (
--    IDVistoria          INT           IDENTITY (1, 1) NOT NULL,
--	  IDFuncionario       INT           NOT NULL,
--    Titulo              VARCHAR (100) NOT NULL,
--    Descritivo          VARCHAR (300) NOT NULL,
--	  [Data]              DATE NULL,

--    PRIMARY KEY CLUSTERED (IDVistoria ASC),
--	  CONSTRAINT [FK_IDFuncionario4] FOREIGN KEY (IDFuncionario) REFERENCES Funcionarios (IDFuncionario),
    
--);

--Create table Fornecedores(
--    IDFornecedor     INT          IDENTITY (1, 1) NOT NULL,
--    IDContacto       INT          NOT NULL,
--    IDBanco          INT          NOT NULL,
--    Nome             VARCHAR(300) NOT NULL, 
--    IBAN             VARCHAR (50) NOT NULL,

--    PRIMARY KEY CLUSTERED (IDFornecedor  ASC),
--    CONSTRAINT [FK_IDContacto3] FOREIGN KEY (IDContacto) REFERENCES Contactos (IDContacto) ON DELETE CASCADE ON UPDATE CASCADE,
--    CONSTRAINT [FK_IDBanco3] FOREIGN KEY (IDBanco) REFERENCES Bancos (IDBanco)

--);

--CREATE TABLE Contratos (
--    IDContrato          INT           IDENTITY (1, 1) NOT NULL,
--    IDFornecedor        INT           NOT NULL,
--	  IDFuncionario       INT           NOT NULL,
--	  IDDocumento         INT           NOT NULL,
--    Titulo              VARCHAR (100) NOT NULL,
--    Descritivo          VARCHAR (300) NOT NULL,
--	  DataInicio          DATE NOT NULL,
--	  DataFim             DATE  NULL,
--	  ValorSemIVA         DECIMAL NOT NULL,
--	  ValorComIVA         DECIMAL NOT NULL,
--	  ContratoSemTermo    BIT NOT NULL,
-- 	  ContratoRescindido  BIT NOT NULL,
--    PRIMARY KEY CLUSTERED (IDContrato ASC),
--    CONSTRAINT [FK_IDFornecedor] FOREIGN KEY (IDFornecedor) REFERENCES Fornecedores (IDFornecedor),
--	  CONSTRAINT [FK_IDFuncionario5] FOREIGN KEY (IDFuncionario) REFERENCES Funcionarios (IDFuncionario),
--    CONSTRAINT [FK_IDDocumento3] FOREIGN KEY (IDDocumento) REFERENCES Documentos (IDDocumento) ON DELETE CASCADE ON UPDATE CASCADE
--);