USE DB_ESCOLA;
GO

ALTER PROCEDURE pr_incluir_curso
(
	@Codigo int,
	@IdEscola int,
	@Descricao varchar (50),
	@Cargahoraria int,
	@Preco float,
	@status int output   --Se for 0: incluido, se for 1: alterado-
)
AS
--todo o conteúdo estará dentro de BEGIN - END 
BEGIN
	IF EXISTS(SELECT @Codigo FROM TBCursos WHERE Codigo = @Codigo)
		BEGIN
		--Quando usar UPDATE, NUNCA ESQUEÇA DO WHERE (senão atualiza TUDO)
			UPDATE TBCursos SET IdEscola = @IdEscola, Descricao = @Descricao, 
			Cargahoraria = @Cargahoraria, Preco = @Preco WHERE Codigo = @Codigo
			--Escolhermos mudar tudo isso, mas poderia mudar um ou outro caso eu quisesse

			SET @status = 1
		END
	ELSE
		BEGIN
			INSERT INTO TBCursos(Codigo, IdEscola, Descricao, Cargahoraria, Preco)
			VALUES (@Codigo, @IdEscola, @Descricao, @Cargahoraria, @Preco)
		
			SET @status = 0
		END
END

