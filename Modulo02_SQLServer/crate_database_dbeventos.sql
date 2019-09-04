use master; --seleciona o banco de dados
GO


CREATE DATABASE DB_EVENTOS --Cria o banco de dados
ON --Seleciona o local para salvar
--PARA O ARQUIVO DE DADOS:
(
	NAME = DB_EVENTOS_DAT,
	FILENAME = N'C:\Users\ta0511\Documents\Sinqia_AspNet\Data\DbEventos.mdf',
	SIZE = 5000KB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 1000KB
	--Digita o caminho completo (no final colocar o arquivo para criar), tamanho
	--Colocar a letra "N" antes, diz que o que vem em seguida é um texto puro (é o mesmo que quando usamos no C# o @)
)
--PARA O ARQUIVO DE LOG:
LOG ON
(
	NAME = DB_EVENTOS_LOG,
	FILENAME = N'C:\Users\ta0511\Documents\Sinqia_AspNet\Data\DbEventos_log.ldf',
	SIZE = 2000KB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 1000KB
);
GO
--hello



