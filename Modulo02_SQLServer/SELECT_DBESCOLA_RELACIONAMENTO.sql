use DB_ESCOLA;
GO

--LISTANDO TODOS OS CURSOS DE TODAS AS ESCOLAS

--Precisa dor WHERE, senão ele vai mostrar tudo (como se todas as escola tivessem todos os cursos)
SELECT * FROM TBEscolas, TBCursos 
WHERE --Filtrar as linhas
	TBEscolas.Id = TBCursos.IdEscola

	--Filtrar coluta também
	--Lista com relacionamento, permitindo seleção de campos
--Declarar variável (Sempre começa com @)
DECLARE @Valor FLOAT;
SET @Valor = 1500; --Atribuindo um valor para a variável

SELECT 
	E.Id,
	E.Descricao AS Escola,
	C.Descricao AS Curso,
	E.Endereco AS Endereço,
	C.Preco AS Preço
FROM 
	TBEscolas E, TBCursos C 
WHERE --Filtrar as linhas / Pode colocar quantas condições quiser
	E.Id = C.IdEscola 
	AND C.Preco >= @Valor;

-- Colsulta envolvendo agrupamentos e funções de agregação
-- Funções
SELECT 
	E.Descricao AS Escola,
	Count(C.Descricao) AS QuantiCursos --Conta quantos cursos tem
FROM
	TBEscolas E, TBCursos C
WHERE 
	E.Id = C.IdEscola
GROUP BY --Dos campos que estçao sendo exibidos, o que se repete eu quero que mostra apenas uma vez
	E.Descricao


--FAZER O MESMO, MAS COM 3 (com o telefone)
SELECT 
	E.Descricao AS Escola,
	E.Telefone AS Telefone,
	Count(C.Descricao) AS QuantiCursos --Conta quantos cursos tem
FROM
	TBEscolas E, TBCursos C
WHERE 
	E.Id = C.IdEscola
GROUP BY --Dos campos que estçao sendo exibidos, o que se repete eu quero que mostra apenas uma vez
	E.Descricao, E.Telefone



--FAZER O MESMO, MAS COM 3 (com o telefone), mas com mais de um telefone pra mesma faculdade
--Ou seja, apresentar as escolas e a quantidade de cursos por escola
SELECT 
	E.Descricao AS Escola,
	E.Telefone AS Telefone,
	Count(C.Descricao) AS QuantiCursos --Conta quantos cursos tem
FROM
	TBEscolas E, TBCursos C
WHERE 
	E.Id = C.IdEscola
GROUP BY --Dos campos que estçao sendo exibidos, o que se repete eu quero que mostra apenas uma vez
	E.Descricao, 
	E.Telefone


--O mesmo, porém, agora somando os preços
SELECT 
	E.Descricao AS Escola,
	E.Telefone AS Telefone,
	Count(C.Descricao) AS QuantiCursos, --Conta quantos cursos tem
	Sum(C.Preco) AS Total
FROM
	TBEscolas E, TBCursos C
WHERE 
	E.Id = C.IdEscola
GROUP BY --Dos campos que estçao sendo exibidos, o que se repete eu quero que mostra apenas uma vez
	E.Descricao, 
	E.Telefone