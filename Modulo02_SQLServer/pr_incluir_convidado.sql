--Criar uma stored procedure (um método) capaz de
--incluir ou alterar um convidade.
--A alteração ocorrerá se o CPF informado já estiver cadastrado
--Salvar o nome do arquivo com o nome da PROCEDURE
USE DB_EVENTOS;
GO

ALTER PROCEDURE pr_incluir_convidado --Poderia ser PROC, e tudo em minúsculo para o nome (começar por pr))
(
	@cpf varchar (11),
	@idevento int,
	@nome varchar (50),
	@telefone varchar (20),
	@email varchar (60),
	@status int output   --Se for 0: incluido, se for 1: alterado
)
AS
--todo o conteúdo estará dentro de BEGIN - END 
BEGIN
	IF EXISTS(SELECT Cpf FROM TBConvidados WHERE Cpf = @cpf)
		BEGIN
		--Quando usar UPDATE, NUNCA ESQUEÇA DO WHERE (senão atualiza TUDO)
			UPDATE TBConvidados SET IdEvento = @idevento, Nome = @nome, 
			Telefone = @telefone, Email = @email WHERE Cpf = @cpf
			--Escolhermos mudar tudo isso, mas poderia mudar um ou outro caso eu quisesse

			SET @status = 1
		END
	ELSE
		BEGIN
			INSERT INTO TBConvidados (Cpf, IdEvento, Nome, Email, Telefone)
			VALUES (@cpf, @idevento, @nome, @email, @telefone)
		
			SET @status = 0
		END
END

