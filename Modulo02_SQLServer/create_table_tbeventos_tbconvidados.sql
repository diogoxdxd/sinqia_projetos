use DB_EVENTOS;
GO

CREATE TABLE TBEventos
(
	Id	int not null IDENTITY(1,1), --não aceita nulo, Identiry é só pra acrescentar(começa em 1, de uma em uma unidade)
	Descricao	varchar(100) not null,
	Responsavel		varchar(50) not null,
	Data	datetime not null,
	Preco	float not null
	PRIMARY KEY(Id)
)
GO

CREATE TABLE TBConvidados
(
	Cpf	varchar(11) not null,
	IdEvento int not null,
	Nome varchar(50) not null,
	Telefone varchar (20) not null,
	Email varchar(60) not null,
	PRIMARY KEY (Cpf),
	FOREIGN KEY (IdEvento) REFERENCES TBEventos(Id) -- referencia a outra tabela e dentro dela a PRIMARY KEY
)
GO

