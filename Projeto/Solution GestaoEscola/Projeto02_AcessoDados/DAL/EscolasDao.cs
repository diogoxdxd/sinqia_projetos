using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public class EscolasDao : Dao<Escola, int>
	{
		public override Escola Buscar(int chave)
		{
			throw new NotImplementedException();
		}

		public override void Incluir(Escola elemento)
		{
			try
			{
				AbrirConexao();
				cmd.CommandText = "INSERT INTO TBEscolas (Descricao, Endereco, Telefone)" +
					" VALUES (@Descricao,@Endereco,@Telefone)";
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("Descricao", elemento.DescricaoEscola);
				cmd.Parameters.AddWithValue("Endereco", elemento.Endereco);
				cmd.Parameters.AddWithValue("Telefone", elemento.Telefone);

				cmd.ExecuteNonQuery();

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{

			}
		}

		public override IEnumerable<Escola> Listar(int id = 0)
		{
			throw new NotImplementedException();
		}
	}
}
