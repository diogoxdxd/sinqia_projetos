using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
    public class CursosDao : Dao<Curso, string>
    {

        public int StatusInslusaoCurso { get; set; }

        public override Curso Buscar(string chave)
        {
            throw new NotImplementedException();
        }

        public override void Incluir(Curso elemento)
        {
            try
            {
                AbrirConexao();
                cmd.CommandText = "pr_incluir_curso"; //OLHAR AQUI (Arrumado)
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                //OLHAR AQUI EMBAIXO 
                cmd.Parameters.AddWithValue("@Codigo", elemento.Codigo);
                cmd.Parameters.AddWithValue("@Cargahoraria", elemento.CargaHoraria);
                cmd.Parameters.AddWithValue("@Descricao", elemento.DescricaoCurso);
                cmd.Parameters.AddWithValue("@Preco", elemento.Preco);
				cmd.Parameters.AddWithValue("@IdEscola", elemento.EscolaInfo.Id);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@status";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parameter);

                cmd.ExecuteNonQuery();
                int status = (int)parameter.Value;
                StatusInslusaoCurso = status;


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
		public void Buscarcodigo()
		{/*
			CursosDao dao = RepositoryDao.Repository

			try
			{
				AbrirConexao();
				if()
				string sql = "SELECT C.Descricao, C.Cargahoraria, C.Preco" +
					" FROM TBCursos C, TBEscolas E WHERE " +
					" C.IdEscola = E.Id AND C.IdEscola = " + id; //OLHAR AQUI (Arrumado)

				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;
				adapter.SelectCommand = cmd;
				adapter.Fill(table);
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
			*/
		}
        public DataTable ListarCursos(int id)
        {
            DataTable table = new DataTable();

            try
            {
                AbrirConexao();

                string sql = "SELECT C.Descricao, C.Cargahoraria, C.Preco" + 
					" FROM TBCursos C, TBEscolas E WHERE " +
					" C.IdEscola = E.Id AND C.IdEscola = " + id; //OLHAR AQUI (Arrumado)

                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                FecharConexao();
            }
            return table;
        }

        public override IEnumerable<Curso> Listar(int id = 0)
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                if(id < 0)
                {
                    throw new Exception("Não é permitido parâmetro negativo");
                }
                AbrirConexao();

                string sql = "SELECT * FROM TBCursos"; //OLHAR AQUI (Arrumado)

                if(id > 0)
                {
                    sql += " WHERE IdEscola = @IdEscola"; //OLHAR AQUI
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IdEscola", id); //OLHAR AQUI
                }
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Curso c = new Curso();
                    //Olhar AQUI (Arrumado)
                    c.CargaHoraria = (int)reader["Cargahoraria"];
                    c.Codigo = (int)reader["Codigo"];
                    c.DescricaoCurso = (string)reader["Descricao"];
                    c.Preco = (double)reader["Preco"];
                    c.EscolaInfo = new EscolasDao().Buscar((int)reader["IdEscola"]);

                    cursos.Add(c);
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
            return cursos;
    
        }
    }
}
