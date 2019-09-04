using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public abstract class Dao<T, K>
	{

		private string conexao = @"Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DB_ESCOLA;Data Source=.";
		protected SqlConnection cn;
		protected SqlCommand cmd;
		protected SqlDataReader reader;
		protected SqlDataAdapter adapter;

		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();
		}

		protected void AbrirConexao()
		{
			cn.Open();
		}
		protected void FecharConexao()
		{
			if(cn != null && cn.State == ConnectionState.Open)
			{
				cn.Close();
			}
		}

		//Métodos Abstratos
		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);
		public abstract IEnumerable<T> Listar(int id = 0);

	}
}
