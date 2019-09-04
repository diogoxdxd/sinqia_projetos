/*Trabalhando com consulta simples */


--SELECT <CAMPOS> FROM <TABEELAS> [RESTRI��ES]
USE DB_ESCOLA;
GO

--Listando todas as escolas
SELECT * FROM TBEscolas

--listando apenas o nome(descri��o) e o telefone
SELECT Descricao,Telefone FROM TBEscolas

--Colocar apelidos e mostrar
SELECT 
	Descricao AS Descri��o, 
	Telefone AS Fone 
FROM TBEscolas

--Forma 2 (pode omitir o "AS")
SELECT 
	Descricao Descri��o, 
	Telefone Fone 
FROM TBEscolas

--Forma 3 (A partir do "E."), � �til para acessar tabelas diferentes (N�o esquecer do "E" no final)
SELECT 
	E.Descricao, E.Endereco
FROM TBEscolas E

--Forma 4 (Nunca fa�a esse)
SELECT
	TBEscolas.Descricao, TBEscolas.Endereco
FROM TBEscolas


--------RESTRI��ES----------
--Descri��o que comece com F (colocar %) ("LIKE" S� vale para varchar e s� usa PARTE da descri��o)
SELECT * FROM TBEscolas WHERE Descricao LIKE 'F%' 

--Descri��o que termina ou come�a com F (colocar %%) ("LIKE" S� vale para varchar e s� usa PARTE da descri��o)
SELECT * FROM TBEscolas WHERE Descricao LIKE '%F%' 

--Descri��o que termina com F (colocar %) ("LIKE" S� vale para varchar e s� usa PARTE da descri��o)
SELECT * FROM TBEscolas WHERE Descricao LIKE '%F' 

--Exatamente igual 
SELECT * FROM TBEscolas WHERE Descricao = 'UNA'

--Entre (o segundo AND � outra restri��o 
SELECT *FROM TBEscolas WHERE 
	Id BETWEEN 2 AND 5 --Entre 2 e 5
	AND Endereco LIKE 'Av%'--Que comece com 'Av'



