USE DB_ESCOLA;
GO

--Se o Id for autoincremento, n�s n�o colocamos ele (como nesse caso)
INSERT INTO TBEscolas (Descricao, Endereco, Telefone)
VALUES ('Impacta Tecnologia', 'Av Paulista, 1009', '11-3542-9665')
--Outro jeito de colcoar valor, bot�o direito na tabela, v� em "Edit Top 200"

--Mais de um por vez
INSERT INTO TBEscolas (Descricao, Endereco, Telefone)
VALUES ('Anhanguera', 'Rua do Rosario, 300', '11-38842-9665'),
		('PUC Minas', 'Av Sinfronio Brochado', '11-5542-995')






