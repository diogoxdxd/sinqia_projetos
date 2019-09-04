using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public abstract class Dao<T, K> //"T" de "type", é alguma coisa que será atribuído a um tipo depois
	{

		//ctor mais rápido
		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();
		}


		//string de conexão
		private string conexao = @"Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DB_EVENTOS;Data Source=.";

		//objetos de acesso a dados
		//namespace System.Data.SqlClient
		//Matem a conexão com o banco de dados
		protected SqlConnection cn;
		//Responsavel por executar as instruções Sql
		protected SqlCommand cmd;
		//Consulta (reader e adapter)
		protected SqlDataReader reader; // Modo conectado (esse é unifimensional, ou seja, ele está lendo o primeiro dado, e agora foi para ler o segunndo. 
										//Quando ele passa para o próximo, ele não consegue mais ter acesso ao anterior
		protected SqlDataAdapter adapter; // Modo desconectado

		//métodos para abrir e fechar a conexão
		protected void AbrirConexao()
		{
			cn.Open();
		}
		protected void FecharConexao()
		{
			if (cn != null && cn.State == ConnectionState.Open) //ou seja, se estiver aberta
			{
				cn.Close();
			}
		}

		//Método abstratos
		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);
		public abstract IEnumerable<T> Listar(int id = 0); //generalização de lista - o "id = 0" diz que se você oferecer um Id, ele vai entrar com esse Id,
		//mas caso você nãi inserir nada, o "Id" recebe o valor "0", e lá no método você implementa
		//que se o "Id == 0", você mostra a lista completa, caso não (ou seja, caso você inserir algo), você pega só o que tem nesse Id


	}
}
