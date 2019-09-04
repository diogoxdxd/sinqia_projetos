<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ChamadosResolvidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ChamadosResolvidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
         <h2 class="text-center">Chamados Resolvidos</h2>
        <div class="row">
            
            <%-- Pedido --%>
            <div class="form-group">
                <asp:Label ID="pedidoLabel" runat="server" Text="Pedido:"></asp:Label>
                <asp:DropDownList ID="pedidosDropDownList1" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged=""></asp:DropDownList>
            </div>
        <hr />

        <asp:Repeater ID="itensRepeater" runat="server">

            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <div class="alert alert-danger" >
                    
                    <div style="float:right;">


                    </div>

                </div>


            </ItemTemplate>
            <FooterTemplate></FooterTemplate>

        </asp:Repeater>


        </div>

    </div>




</asp:Content>
