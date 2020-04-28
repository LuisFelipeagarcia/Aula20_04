<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="detalhes.aspx.cs" Inherits="_04_20_BDMySQL.detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center text-primary">
        <h2>Consulta de Dados do Cliente</h2>
    </div>
    
    <div class="row" style="margin-top:15px;">
        <div class="col-md-2">
            <label>ID: </label>
            <asp:TextBox ID="txtId" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div class="col-md-10">
            <label>Nome: </label>
            <asp:TextBox ID="txtNome" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top:15px;">
        <div class="col-md-7">
            <label>Logradouro: </label> 
            <asp:TextBox ID="txtLogradouro" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-2">
            <label>Número: </label>
            <asp:TextBox ID="TxtNumero" runat="server" MaxLength="5" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-3">
            <label>Complemento: </label>
            <asp:TextBox ID="TxtComplemento" runat="server" MaxLength="10" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top:15px;">
        <div class="col-md-5">
            <label>Bairro: </label>
            <asp:TextBox ID="txtBairro" runat="server" MaxLength="50" CssClass="form-control"  Enabled="false"></asp:TextBox>
        </div>
        <div class="col-md-5">
            <label>Cidade: </label>
            <asp:TextBox ID="txtCidade" runat="server" MaxLength="50" CssClass="form-control"  Enabled="false"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>UF: </label>
            <asp:TextBox ID="txtUF" runat="server" MaxLength="2" CssClass="form-control"  Enabled="false"></asp:TextBox>
        </div>
    </div>
</asp:Content>
