using DesenvolvimentoWeb.Vendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class ListaItensAjax : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				pedidosDropDownList1.DataSource = PedidosDao.ListarPedidosVM();
				pedidosDropDownList1.DataTextField = "NomeCliente";
				pedidosDropDownList1.DataValueField = "NumeroPedido";
				pedidosDropDownList1.DataBind();
				pedidosDropDownList1.Items.Insert(0, "SELECIONE UM PEDIDO");
			}

		}

		protected void excluirLinkButton_Click(object sender, EventArgs e)
		{
			var x = ((LinkButton)sender).CommandArgument;

			ItensDao.RemoverItem(int.Parse(x));
			ListarItens();
		}

		protected void pedidosDropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListarItens();
		}
		private void ListarItens()
		{
			string numeroPedido = pedidosDropDownList1.SelectedValue;

			itensRepeater.DataSource = ItensDao.ListarItensPorPedido(numeroPedido);
			itensRepeater.DataBind();
		}

	}
}