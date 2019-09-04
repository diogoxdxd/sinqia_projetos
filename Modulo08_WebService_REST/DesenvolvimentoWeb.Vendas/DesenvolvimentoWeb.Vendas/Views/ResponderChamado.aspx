<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ResponderChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ResponderChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
      <div class="container">
           <h2 class="text-center">Resposta a Chamados</h2>
          <div class="row">
                <div class="col-md-7">

                     <%-- Chamado --%>
                     <div class="form-group">
                         <asp:Label ID="chamadoLabel" runat="server" Text="Chamado:"></asp:Label>
                         <asp:DropDownList ID="chamadoDropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
                      </div>

                    <%-- Botão Buscar --%>
                    <div class="form-group">
                         <asp:Button ID="buscarButton" CssClass="btn btn-info" runat="server" Text="Buscar Chamado" OnClick="buscarButton_Click" />
                        <%-- Deletar Buscar --%>
                         <asp:Button ID="deletarButton" CssClass="btn btn-danger" runat="server" Text="Deletar Chamado" OnClick="deletarButton_Click" />
                    </div> 

                    <%-- Buscar Chamado --%>
                      <div class="form-group">
                            <asp:Label ID="buscarLabel" runat="server" Text="Descricao:"></asp:Label>
                            <asp:TextBox ID="descricaoTextBox" CssClass="form-control text-primary" TextMode="MultiLine" Rows="4" Columns="50" ReadOnly="true" runat="server"></asp:TextBox>
                       </div>



                    <%-- Responder Chamado--%>
                    <div class="form-group">
                            <asp:Label ID="responderLabel" runat="server" Text="Responder:"></asp:Label>
                            <asp:TextBox ID="responderTextBox" CssClass="form-control" TextMode="MultiLine"  Rows="4" Columns="50" runat="server"></asp:TextBox>
                    </div>

                    <%-- Botão Responder --%>
                    <div class="form-group">
                         <asp:Button ID="enviarButton" CssClass="btn btn-danger" runat="server" Text="Responder Chamado" OnClick="enviarButton_Click" />
                    </div> 

                     <%-- Mensagem --%>
                        <div>
                            <asp:Label ID="mensagemLabel" runat="server" style="width:100%"></asp:Label>
                        </div>



                </div>

          </div>


      </div>





</asp:Content>
