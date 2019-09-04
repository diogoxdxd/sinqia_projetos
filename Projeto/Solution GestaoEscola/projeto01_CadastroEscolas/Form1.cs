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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
				//embaixo não feito
				escola.Preco = Convert.ToDouble(precoTextBox.Text);

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
	}
}
