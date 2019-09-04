using projeto01_CadastroEscolas.RepositoryDao;
using Projeto02_AcessoDados.DAL;
using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto01_CadastroEscolas
{
	public partial class cadastroForm : Form
	{
		public cadastroForm()
		{
			InitializeComponent();
            ListarEscolas();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void inserirEscolaButton_Click(object sender, EventArgs e)
		{
			try
			{
				Escola escola = new Escola();
				escola.DescricaoEscola = descricaoEscolaTextBox.Text;
				escola.Endereco = enderecoTextBox.Text;
				escola.Telefone = telefoneTextBox.Text;

                EscolasDao dao = Repository.GetEscolasDao();
                dao.Incluir(escola);
                ListarEscolas();

                MessageBox.Show("Escola incluída com sucesso");

                descricaoEscolaTextBox.Clear();
                enderecoTextBox.Clear();
                telefoneTextBox.Clear();
                descricaoEscolaTextBox.Focus();

			}
			catch (Exception ex) //ex é de "exception"
			{
				MessageBox.Show(ex.Message);

			}
		}
        public void ListarEscolas()
        {
            try
            {
                EscolasDao dao = Repository.GetEscolasDao();
                escolasComboBox.DataSource = dao.Listar();
				escolasComboBox.DisplayMember = "DescricaoEscola"; //NOME DA CAIXA
				escolasComboBox.ValueMember = "Id"; //OLHAR AQUI (Arrumado)

			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InserirCursoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = new Curso();
                CursosDao dao = Repository.GetCursosDao();

                curso.Codigo = Convert.ToInt32(codigoTextBox.Text);//OLHAR AQUI (Talvez)
                curso.CargaHoraria = Convert.ToInt32(cargaHorariaTextBox.Text);
                curso.DescricaoCurso = descricaoCursoTextBox.Text;
                curso.Preco = Convert.ToDouble(precoTextBox.Text);

                int id = (int)escolasComboBox.SelectedValue; //OLHAR AQUI (Talvez)

				curso.EscolaInfo = Repository.GetEscolasDao().Buscar(id);

                dao.Incluir(curso);
                if(dao.StatusInslusaoCurso == 1)
                {
                    MessageBox.Show("Cursos alterado com sucesso");
                }
                else
                {
                    MessageBox.Show("Curso incluído com sucesso");
                }

                codigoTextBox.Clear();
                cargaHorariaTextBox.Clear();
                descricaoCursoTextBox.Clear();
                precoTextBox.Clear();
                codigoTextBox.Focus();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = (int)escolasComboBox.SelectedValue;
                CursosDao dao = Repository.GetCursosDao();

                cursosDataGridView.DataSource = dao.ListarCursos(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void buscarCodigoButton_Click(object sender, EventArgs e)
		{
			/*
			Curso curso = new Curso();
			CursosDao dao = Repository.GetCursosDao();

			if(dao.StatusInslusaoCurso == 1)
			{
				CursosDao.Buscarcodigo(dao);
			}
			else
			{
				//throw MessageBox()
			}

					//AbrirConexao();

					string sql = "SELECT C.Descricao, C.Cargahoraria, C.Preco" +
						" FROM TBCursos C, TBEscolas E WHERE " +
						" C.IdEscola = E.Id AND C.IdEscola = " + id; //OLHAR AQUI (Arrumado)

					cmd.CommandText = sql;
					cmd.CommandType = CommandType.Text;
					adapter.SelectCommand = cmd;
					adapter.Fill(table);
	
				
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
				*/



		}
	}
}
