--Insert
USE DB_ESCOLA;
GO

INSERT INTO TBCursos 
	(Codigo,IdEscola,Descricao,Cargahoraria,Preco) 
VALUES 
	(100, 1,'Engenharia Civil', 6000, 450),
	(200, 1,'Psicologia', 4000,1500),
	(300, 3,'Matematica', 3600,1200),
	(400, 3,'Engenharia Civil',5000, 1450),
	(500, 3,'Analise de Sistemas', 3600, 1100),
	(600, 4,'Engenharia de Computaçao', 6000, 2200)

INSERT INTO TBCursos
	(Codigo, IdEscola, Descricao,Cargahoraria,Preco)
VALUES 
	(700, 5,'Engenharia Mecanica', 6000,3000)




