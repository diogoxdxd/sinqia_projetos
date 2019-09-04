using Projeto01_CadastroEventos.RepositoryDao;
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

namespace Projeto01_CadastroEventos
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
			ListarEventos();
		}

		private void incluirEventoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Evento evento = new Evento();
				evento.Descricao = descricaoTextBox.Text;
				evento.Responsavel = responsavelTextBox.Text;
				evento.Data = Convert.ToDateTime(dataMaskedTextBox.Text);
				evento.Preco = Convert.ToDouble(precoTextBox.Text);

				EventosDao dao = Repository.GetEventosDao();
				dao.Incluir(evento);
				ListarEventos();


				MessageBox.Show("Evento incluído com sucesso");

				//Limpando os campos de entrada
				descricaoTextBox.Clear();
				responsavelTextBox.Clear();
				dataMaskedTextBox.Clear();
				precoTextBox.Clear();

				//Voltar o cursor na primeira caixa de texto
				descricaoTextBox.Focus();


			}
			catch (Exception ex) //ex é de "exception"
			{
				MessageBox.Show(ex.Message);
			
			}
		}

		private void ListarEventos()
		{
			try
			{
				EventosDao dao = Repository.GetEventosDao();
				eventoComboBox.DataSource = dao.Listar();
				eventoComboBox.DisplayMember = "Descricao"; //é o que vai mostrar na parte do "Eventos", é o Text
				eventoComboBox.ValueMember = "Id"; //É onde ele vai realmente acessar
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//this.Close();
			}
		}

		private void incluirConvidadoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Convidado convidado = new Convidado();
				ConvidadosDao dao = Repository.GetConvidadosDao();

				convidado.Cpf = cpfTextBox.Text;
				convidado.Nome = nomeTextBox.Text;
				convidado.Email = emailTextBox.Text;
				convidado.Telefone = telefoneTextBox.Text;

				//Obtendo o Id do evento a partir do ComboBox
				int id = (int)eventoComboBox.SelectedValue;

				convidado.EventoInfo = Repository.GetEventosDao().Buscar(id);

				//incluindo o convidado no banco de dados
				dao.Incluir(convidado);
				if (dao.StatusInclusaoConvidado == 1)
				{
					MessageBox.Show("Convidado alterado com sucesso");
				}
				else
				{
					MessageBox.Show("Convidado incluído com sucesso");
				}
				cpfTextBox.Clear();
				nomeTextBox.Clear();
				emailTextBox.Clear();
				telefoneTextBox.Clear();
				cpfTextBox.Clear();
				cpfTextBox.Focus();


			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error); //(a mensagem do erro,)
			}
		}

		private void buscarConvidadosButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)eventoComboBox.SelectedValue;
				ConvidadosDao dao = Repository.GetConvidadosDao();
				//convidadosDataGridView.DataSource = dao.Listar(id);
				convidadosDataGridView.DataSource = dao.ListarConvidados(id);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}





		/*	private void FormCadastro_Load(object sender, EventArgs e)
			{

			}*/
	}
}
