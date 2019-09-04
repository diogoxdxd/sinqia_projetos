using DesenvolvimentoWeb.Vendas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class ResponderChamado : System.Web.UI.Page
	{
		HttpClient client;
		static Chamado chamado;

		private async void ListarChamados()
		{
			HttpResponseMessage response = client.GetAsync("chamadosPendentes").Result;

				var resultado = await response.Content.ReadAsStringAsync();

				var lista = JsonConvert.DeserializeObject<Chamado[]>(resultado).ToList();

				chamadoDropDownList1.DataSource = lista;
				chamadoDropDownList1.DataTextField = "ChamadoId";
				chamadoDropDownList1.DataValueField = "ChamadoId";
				chamadoDropDownList1.DataBind();

				enviarButton.Enabled = (chamado != null);
			
		}

		protected async void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				try
				{
					HttpResponseMessage response = client.GetAsync("chamadosPendentes").Result;

					if (response.IsSuccessStatusCode)
					{
						var resultado = await response.Content.ReadAsStringAsync();

						var lista = JsonConvert.DeserializeObject<Chamado[]>(resultado).ToList();

						chamadoDropDownList1.DataSource = lista;
						chamadoDropDownList1.DataTextField = "ChamadoId";
						chamadoDropDownList1.DataValueField = "ChamadoId";
						chamadoDropDownList1.DataBind();

						enviarButton.Enabled = (chamado != null);
					}

				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public ResponderChamado()
		{
			if (client == null)
			{
				client = new HttpClient();
				client.BaseAddress = new Uri("http://localhost:52289/");
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			}
		}

		//Chamado chamado = null;

		protected async void buscarButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = int.Parse(chamadoDropDownList1.SelectedValue);

				HttpResponseMessage response = client.GetAsync("api/chamados/" + id).Result;

				if (response.IsSuccessStatusCode)
				{
					var resultado = await response.Content.ReadAsStringAsync();

					chamado = JsonConvert.DeserializeObject<Chamado>(resultado);

					enviarButton.Enabled = (chamado != null);
					deletarButton.Enabled = (chamado != null);

					descricaoTextBox.Text = chamado.Assunto + "\n\n" + chamado.Descricao;

				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		protected async void enviarButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (chamado == null)
				{
					throw new Exception("Por favor, buscar chamado");
				}
				chamado.Resposta = responderTextBox.Text;

				string json = JsonConvert.SerializeObject(chamado);

				HttpContent content = new StringContent(json, Encoding.Unicode, "application/json");

				var response = await client.PutAsync("api/chamados", content);

				if (response.IsSuccessStatusCode)
				{

					mensagemLabel.CssClass = "alert alert-success";
					mensagemLabel.Text = "Chamado respondido com sucesso";
				}
				else
				{
					string erro = response.StatusCode + " - " + response.ReasonPhrase;
					throw new Exception(erro);
				}
			}
			catch (Exception ex)
			{

				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}

		}

		protected async void deletarButton_Click(object sender, EventArgs e)
		{


			try
			{
				if (chamado.Resolvido == 1)
				{
					throw new Exception("Chamado já resolvido");
				}

				int id = int.Parse(chamadoDropDownList1.SelectedValue);

				HttpResponseMessage response = client.DeleteAsync("api/chamados/" + id).Result;

				if (response.IsSuccessStatusCode)
				{
					var resultado = await response.Content.ReadAsStringAsync();

					chamado = JsonConvert.DeserializeObject<Chamado>(resultado);

					enviarButton.Enabled = (chamado != null);
					deletarButton.Enabled = (chamado != null);

					ListarChamados();
					descricaoTextBox.Text = "";


				}
			}
			catch (Exception)
			{
				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = "Não há chamados";
			}





		}
	}
}