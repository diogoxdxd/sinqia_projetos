<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroUsuarios.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
     <div class="container">
         <h2 class="text-center">Cadastro de Usuários</h2>

          <div class="row"> 
              <div class="col-md-5">

                   <div class="form-group">
                        <asp:Label ID="nomeLabe" runat="server" Text="Nome:"></asp:Label>
                        <asp:TextBox ID="nomeTextBox" MaxLength="20" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ID="nomeRequiredFieldValidator1" 
                            ControlToValidate="nomeTextBox" 
                            runat="server" 
                            CssClass="text-danger"
                            ErrorMessage="O nome do usuário deve ser informado" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>

                  <div class="form-group">
                        <asp:Label ID="senhaLabel1" runat="server" Text="Senha:"></asp:Label>
                        <asp:TextBox ID="senhaTextBox1" MaxLength="20" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ID="senhaRequiredFieldValidator1" 
                            ControlToValidate="senhaTextBox1" 
                            runat="server" 
                            CssClass="text-danger"
                            ErrorMessage="A senha deve ser informada" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="confirmaLabel1" runat="server" Text="Confirme sua senha:"></asp:Label>
                        <asp:TextBox ID="confirmaTextBox1" MaxLength="20" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:CompareValidator 
                            ID="confirmaCompareValidator1" 
                            runat="server" 
                            ErrorMessage="As senhas não conferem" 
                            ControlToCompare="senhaTextBox1"
                            CssClass="text-danger"
                            ControlToValidate="confirmaTextBox1"
                            Display="Dynamic">
                        </asp:CompareValidator>
                    </div>

                    <div class="form-group">
                         <asp:Button ID="enviarButton" CssClass="btn btn-danger" runat="server" Text="Incluir Usuário" OnClick="enviarButton_Click" />
                    </div> 
                  
                    <div>
                        <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                    </div>


              </div>

          </div>


     </div>
</asp:Content>
