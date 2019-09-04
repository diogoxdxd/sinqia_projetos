<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ListaItensAjax.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ListaItensAjax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
               <div class="container">
                  <h2 class="text-danger text-center">Listar Itens</h2>
    
                    <%-- Pedido + Cliente --%>
                    <div class="form-group">
                        <asp:Label ID="pedidoLabel" runat="server" Text="Pedido:"></asp:Label>
                        <asp:DropDownList ID="pedidosDropDownList1" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="pedidosDropDownList1_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                <hr />

                <asp:Repeater ID="itensRepeater" runat="server">

                    <HeaderTemplate></HeaderTemplate>
                    <ItemTemplate>
                        <div class="alert alert-danger" >
                    
                            <div style="float:right;">
                                <asp:LinkButton 
                                    ID="excluirLinkButton" 
                                    runat="server" 
                                    OnClientClick="javascript:return confirm('Tem certeza?');"
                                    OnClick="excluirLinkButton_Click"
                                    CommandArgument='<%# Eval("IdItem") %>'>
                                    [x]

                                </asp:LinkButton>

                            </div>

                            <strong>Produto:</strong>
                            <asp:Label ID="produtoLabel" 
                                runat="server" 
                                Text='<%# Eval("DescricaoProduto") %>'>
                            </asp:Label> <br />

                           <strong>Num. Pedido:</strong>
                            <asp:Label ID="numPedidoLabel" 
                                runat="server" 
                                Text='<%# Eval("NumeroPedido") %>'>
                            </asp:Label>

                            <strong>Data Pedido:</strong>
                            <asp:Label ID="dataPedidoLabel" 
                                runat="server" 
                                Text='<%# Eval("DataPedido") %>'>
                            </asp:Label> <br />

                            <strong>Valor Pedido:</strong>
                            <asp:Label ID="valorPedidoLabel" 
                                runat="server" 
                                Text='<%# Eval("ValorTotalItem") %>'>
                            </asp:Label> <br />

                        </div>


                    </ItemTemplate>
                    <FooterTemplate></FooterTemplate>

                </asp:Repeater>

             </div>
        </ContentTemplate>

    </asp:UpdatePanel>



</asp:Content>
