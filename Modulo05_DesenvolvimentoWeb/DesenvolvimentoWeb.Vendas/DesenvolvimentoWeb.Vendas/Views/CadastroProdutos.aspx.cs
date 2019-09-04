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
	public partial class CadastroProdutos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				categoriaDropDownList1.DataSource = ProdutosDao.ListarCategorias();
				categoriaDropDownList1.DataTextField = "Descricao";
				categoriaDropDownList1.DataValueField = "Id";
				categoriaDropDownList1.DataBind();

				List<string> unidades = new List<string>()
				{
					"KILO", "PACOTE", "POLEGADAS", "LITROS", "GRAMAS", "DECIBEIS", "UNIDADE"
				};

				unidadeDropDownList1.DataSource = unidades;
				unidadeDropDownList1.DataBind();

				produtosRepeater.DataSource = ProdutosDao.ListarProdutos();
				produtosRepeater.DataBind();
			}
		}

		protected void enviarButton_Click(object sender, EventArgs e)
		{
			try
			{
				HttpPostedFile file = figuraFileUpload.PostedFile;

				//Verificação da foto
				if(file == null || string.IsNullOrEmpty(file.FileName) || file.InputStream == null)
				{
					throw new Exception("Arquivo inválido para o produto");
				}

				Produto produto = new Produto();
				produto.IdCategoria = Convert.ToInt32(categoriaDropDownList1.SelectedValue);
				produto.Descricao = descricaoTextBox.Text;
				produto.Unidade = unidadeDropDownList1.SelectedValue;
				produto.Preco = Convert.ToDouble(precoTextBox.Text);

				produto.MimeType = file.ContentType;

				//obtendo o fluxo de bytes do arquivo, e criando um array de byte
				byte[] bytes = new byte[file.InputStream.Length];
				file.InputStream.Read(bytes, 0, bytes.Length);
				produto.Foto = bytes;

				ProdutosDao.IncluirProduto(produto);

				mensagemLabel.CssClass = "alert alert-success";
				mensagemLabel.Text = "Produto incluído com sucesso";
			}
			catch (Exception ex)
			{
				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}
		}

		protected void produtosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
		{
			//Obtendo uma referência ao controle HiddenField
			HiddenField idField = (HiddenField)e.Item.FindControl("idHiddenField");

			if(idField != null)
			{
				int id = Convert.ToInt32(idField.Value);
				Image image = (Image)e.Item.FindControl("produtoImage");
				//atribuindo a imagem ao controle Image
				image.ImageUrl = "data:" + ProdutosDao.BuscarProduto(id).MimeType + ";base64," + ProdutosDao.ExibirImagem(id);
			}

		}
	}
}