using DesenvolvimentoWeb.Vendas.Data;
using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(Session["sessao_usuario"] != null)
			{
				//Session.Remove("sessao_usuario");
				//ou
				Session.Abandon();
			}
		}

		protected void enviarButton_Click(object sender, EventArgs e)
		{
			try
			{
				Usuario usuario = UsuariosDao.ValidarUsuario(usuarioTextBox.Text, senhaTextBox.Text);
				if(usuario == null)
				{
					throw new Exception("Usuário ou senha inválidos");
				}

				Session["sessao_usuario"] = usuario;
				//ou
				//Session.Add("sessao_usuario", usuario);

				Response.Redirect("Home.aspx");
			}
			catch (Exception ex)
			{
				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}