/*Trabalhando com consulta simples */


--SELECT <CAMPOS> FROM <TABEELAS> [RESTRIÇÕES]
USE DB_ESCOLA;
GO

--Listando todas as escolas
SELECT * FROM TBEscolas

--listando apenas o nome(descrição) e o telefone
SELECT Descricao,Telefone FROM TBEscolas

--Colocar apelidos e mostrar
SELECT 
	Descricao AS Descrição, 
	Telefone AS Fone 
FROM TBEscolas

--Forma 2 (pode omitir o "AS")
SELECT 
	Descricao Descrição, 
	Telefone Fone 
FROM TBEscolas

--Forma 3 (A partir do "E."), é útil para acessar tabelas diferentes (Não esquecer do "E" no final)
SELECT 
	E.Descricao, E.Endereco
FROM TBEscolas E

--Forma 4 (Nunca faça esse)
SELECT
	TBEscolas.Descricao, TBEscolas.Endereco
FROM TBEscolas


--------RESTRIÇÕES----------
--Descrição que comece com F (colocar %) ("LIKE" Só vale para varchar e só usa PARTE da descrição)
SELECT * FROM TBEscolas WHERE Descricao LIKE 'F%' 

--Descrição que termina ou começa com F (colocar %%) ("LIKE" Só vale para varchar e só usa PARTE da descrição)
SELECT * FROM TBEscolas WHERE Descricao LIKE '%F%' 

--Descrição que termina com F (colocar %) ("LIKE" Só vale para varchar e só usa PARTE da descrição)
SELECT * FROM TBEscolas WHERE Descricao LIKE '%F' 

--Exatamente igual 
SELECT * FROM TBEscolas WHERE Descricao = 'UNA'

--Entre (o segundo AND é outra restrição 
SELECT *FROM TBEscolas WHERE 
	Id BETWEEN 2 AND 5 --Entre 2 e 5
	AND Endereco LIKE 'Av%'--Que comece com 'Av'



