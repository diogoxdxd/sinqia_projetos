USE DB_EVENTOS;
GO

--selecionar todos os eventos cujos os preços estejam entre 500 e 1000 reais

SELECT * FROM TBEventos 
WHERE 
	Preco BETWEEN 500 AND 1000

--selecionar todos os convidados (nome, email) que estiverem inscritos em eventos gratis
SELECT 
	C.Nome,
	C.Email
FROM 
	TBConvidados C, TBEventos E
WHERE
	E.Id = C.IdEvento
	AND E.Preco = 0

--Apresentar a quantidade de convidados por evento (exibir o nome do evento e a quantidade)
SELECT 
	E.Descricao,Count(C.Cpf)
FROM
	TBConvidados C, TBEventos E
WHERE
	E.Id = C.IdEvento
GROUP BY
	E.Descricao

--Apresentar o valor arrecadado por evento (apresentar o nome do evento e o total pago pelos convidados)
SELECT 
	E.Descricao, SUM(E.Preco)
FROM	
	TBConvidados C, TBEventos E
WHERE
	E.Id = C.IdEvento
GROUP BY
	E.Descricao






