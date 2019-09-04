USE DB_EVENTOS;
GO

--Inserir dados na tabela TBEventos (eventos)
--Obs: As datas podem ser fornecidas nos formatos:
	--MES/DIA/ANO ou
	--ANO/MES/DIA
INSERT INTO TBEventos (Descricao, Responsavel, Data, Preco)
	VALUES 
	('Palestra Javascript','Prof. João','08/12/2019',500),
	('Festa UFABC', 'Pablo Vittar', '10/22/2019', 50),
	('Festa Berrleaders', 'Angelina Joulie', '08/25/2019', 65),
	('Festa Muay Thai', 'Brad Pitt', '12/08/2019', 69);

INSERT INTO TBConvidados(Cpf, Nome,Telefone,Email, IdEvento)
	VALUES 
	('45898585858', 'Jordan Foreman', '12556-96852','jordamlegal29@hotmail.com',1),
	('25636698951', 'Anitta', '9898-25225','anittabunita@outlook.com',1),
	('98547712563', 'Rihanna', '98885-55554','mandownriri@outlook.com',2),
	('12356965887', 'Valesca', '025899-9899','vava@hotmail.com',2),
	('12555636333', 'Emilie Clarice', '2222-2222','emilie2222@gmail.com',3),
	('65445852366', 'Demi', '7987-987-99','555deminha@hotmail.com',3),
	('12131321322', 'Jake New', '15548-999','jakejake@hotmail.com',4),
	('98986565655', 'Beyonce', '222-444','queenbee@outlook.com',4);

--Transferindo dados para a tabela TBEventos para a tabela TBEventos, mediante consulta
INSERT INTO TBEventos (Descricao, Responsavel, Data, Preco)
SELECT Descricao, Responsavel, Data, Preco FROM TBEventosBackup

--Mostrar tudo
SELECT * FROM TBEventos

--Se eu quiser remover pelo Id algum especifico ou maiores que alguma coisa (NUNCA FAÇA "DELETE' SEM WHERE)
DELETE FROM TBEventos WHERE Id >= 16
--Com o Between (entre 16 e 32)
DELETE FROM TBEventos WHERE Id BETWEEN 16 AND 32








