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
            Escola escola = null;
            try
            {
                AbrirConexao();
                cmd.CommandText = "SELECT * FROM TBEscolas WHERE Id = @Id"; //OLHAR AQUI
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", chave); //OLHAR AQUI (Arrumado)

                reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    escola = new Escola();
                    ////OLHAR AQUI EMBAIXO
                    escola.Id = (int)reader["Id"];
                    escola.DescricaoEscola = (string)reader["Descricao"];
                    escola.Endereco = (string)reader["Endereco"];
                    escola.Telefone = (string)reader["Telefone"];
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                FecharConexao();
            }
            return escola;
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
                FecharConexao();
			}
		}

		public override IEnumerable<Escola> Listar(int id = 0)
		{
            List<Escola> escolas = new List<Escola>();

            try
            {
               // if(id != 0)
                //{
                  //  throw new Exception("Nenhum parametro deve ser inserido");
                //}

                AbrirConexao();
                cmd.CommandText = "SELECT * FROM TBEscolas"; //Olhar Aqui (Arrumado)
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();
                

                while(reader.Read())
                {
                    Escola escola = new Escola();
                    //OLHAR AQUI EMBAIXO
                    escola.Id = (int)reader["Id"];
                    escola.DescricaoEscola = (string)reader["Descricao"];
                    escola.Endereco = (string)reader["Endereco"];
                    escola.Telefone = (string)reader["Telefone"];

                    escolas.Add(escola);

                }

				reader.Read();
			}
            catch (Exception)
            {

                throw;
            }
            finally
            {
                FecharConexao();
            }

            return escolas;
		}
	}
}
