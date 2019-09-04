using ProjetoWeb_CadastroEventos.Dados;
using ProjetoWeb_CadastroEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWeb_CadastroEventos.Paginas
{
	public partial class CadastroConvidados : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string s = Request.RequestType;

			if(!IsPostBack)
			{
				try
				{
					eventoDropDownList.DataSource = EventosDao.ListarEventos();//gera a lista de eventos
					eventoDropDownList.DataTextField = "Descricao"; //as propriedades que serão exibidas para o usuário

					eventoDropDownList.DataValueField = "Id";
					eventoDropDownList.DataBind(); //pra windows form não precisa, pra web sim

					//Sempre que se dá um "post" (uma requisição), ele carrega a página desde o inicio, ou seja,
					//Ele entra no método "Page_Load", e por isso, ele volta sempre pro primeiro evento,
					//não importando qual evento você escolhe
					//A partir da segunda vez de load ele não dá mais "post", mas sim só "post-back",
					//por isso a necessidade do "if"
				}
				catch (Exception)
				{

					throw;
				}
			}

		}

		protected void incluirButton_Click(object sender, EventArgs e)
		{
			try
			{
				Convidado convidado = new Convidado();
				convidado.Cpf = cpfTextBox.Text;
				convidado.IdEvento = Convert.ToInt32(eventoDropDownList.SelectedValue); //SelectedValue na Web é string, por isso a necessidade de conversão
				convidado.Nome = nomeTextBox.Text;
				convidado.Email = emailTextBox.Text;
				convidado.Telefone = telefoneTextBox.Text;

				ConvidadosDao.IncluirConvidado(convidado);

				mensagemLabel.ForeColor = System.Drawing.Color.Blue;
				mensagemLabel.Text = "Convidado incluído com sucesso";

				//O cliente na aplicação WEB é o Browser (front-End), e o servidor é o IIS(Internet Information Services)  (Back-End)
				//Requisição e resposta, é o post e o Back
				//No Brwoser, F5 não atualiza a página, ele realiza a última operação
				//Get é chamada a URL no Browser (Quando você clica em um link, você faz um Get)
				//Post no Browser está relacionado a formulários (login, cadastro,etc) que envia para o servidor
			}
			catch (Exception ex)
			{

				mensagemLabel.ForeColor = System.Drawing.Color.Red;
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}