using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public class EventosDao : Dao<Evento, int> //<diz o que é aquele "T" da classe Dao>
	{
		public override Evento Buscar(int chave)
		{
			Evento evento = null;

			try
			{
				AbrirConexao();
				cmd.CommandText = "SELECT * FROM TBEventos WHERE Id = @Id";
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@Id", chave);
				//executar a consulta
				reader = cmd.ExecuteReader();
				//Não precisa ser "while" porque só do o Id, que é único
				if (reader.Read())
				{
					evento = new Evento();

					evento.Id = (int)reader["Id"]; //seleciona o campo de consulta, dizendo o seu tipo
					evento.Descricao = (string)reader["Descricao"]; //seleciona o campo de consulta, dizendo o seu tipo 
					evento.Responsavel = reader["Responsavel"].ToString();//seleciona o campo de consulta, dizendo o seu tipo (como é string, pode se quiser fazer desse jeito
					evento.Data = (DateTime)reader["Data"];//seleciona o campo de consulta, dizendo o seu tipo
					evento.Preco = (double)reader["Preco"];//seleciona o campo de consulta, dizendo o seu tipo

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

			return evento;
		}

		public override void Incluir(Evento elemento)
		{
			try
			{
				AbrirConexao();
				cmd.CommandText = "INSERT INTO TBEventos (Descricao, Responsavel," +
					"Data, Preco) VALUES (@Descricao, @Resonsavel, @Data, @Preco)"; //coloca ou uma instrução Sql ou o nome de uma procedure. 
																					//No "Values", os parâmetros precisam ter o "@" antes
				cmd.CommandType = CommandType.Text; //execta o anterior

				cmd.Parameters.Clear(); //Para caso tiver algo dentro, ele limpar para não dar erro depois
				cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao); //(Nome do parametro, Valor do Parametro)
				cmd.Parameters.AddWithValue("@Resonsavel", elemento.Responsavel);
				cmd.Parameters.AddWithValue("@Data", elemento.Data);
				cmd.Parameters.AddWithValue("@Preco", elemento.Preco);

				cmd.ExecuteNonQuery(); //Executa o que está ali em cima

			}
			catch (Exception)
			{

				throw;
			}
			finally //sempre é executado, idependente do que acontece no try e o catch
			{
				FecharConexao();
			}
		}

		public override IEnumerable<Evento> Listar(int id = 0)
		{
			List<Evento> eventos = new List<Evento>();

			try
			{
				if (id != 0)
				{
					throw new Exception("Nenhum parâmetro deve ser informado"); //Criou a excessão, e caso dar esse erro, ele será mostrado indo para p "catch"
				}
				
				AbrirConexao();
				cmd.CommandText = "SELECT * FROM TBEventos";
				cmd.CommandType = CommandType.Text; //Porque não é procedure

				//Pra fazer consulta, não usa "executeNonQuery", mas sim:
				reader = cmd.ExecuteReader(); //reader referencia a consulta inteira
				reader.Read();

				while (reader.Read()) //enquanto existe uma linha que está sendo lida (ele lê linha por linha, e não volta na linha anterior
				{
					Evento evento = new Evento();

					evento.Id = (int)reader["Id"]; //seleciona o campo de consulta, dizendo o seu tipo
					evento.Descricao = (string)reader["Descricao"]; //seleciona o campo de consulta, dizendo o seu tipo 
					evento.Responsavel = reader["Responsavel"].ToString();//seleciona o campo de consulta, dizendo o seu tipo (como é string, pode se quiser fazer desse jeito
					evento.Data = (DateTime)reader["Data"];//seleciona o campo de consulta, dizendo o seu tipo
					evento.Preco = (double)reader["Preco"];//seleciona o campo de consulta, dizendo o seu tipo

					eventos.Add(evento); //"eventos" é a coleção que eu tenho, "evento" é o objeto


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

			return eventos;

		}
	}
}
