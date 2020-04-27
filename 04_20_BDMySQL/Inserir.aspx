﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Inserir.aspx.cs" Inherits="_04_20_BDMySQL.Inserir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center text-primary">
        <h2> Cadastro de Clientes</h2> 
    </div>
    <div class="row" style="margin-top:15px;">
        <div class="col-md-12">
            <label>Nome: </label>
            <asp:RequiredFieldValidator ID="rfvNome" ControlToValidate="txtNome" 
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtNome" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top:15px;">
        <div class="col-md-7">
            <label>Logradouro: </label>
            <asp:RequiredFieldValidator ID="rfvLogradouro" ControlToValidate="txtLogradouro" 
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtLogradouro" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-2">
            <label>Número: </label>
            <asp:RequiredFieldValidator ID="rfvNumero" ControlToValidate="txtNumero" 
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="TxtNumero" runat="server" MaxLength="5" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-3">
            <label>Complemento: </label>
            <asp:TextBox ID="TxtComplemento" runat="server" MaxLength="10" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="margin-top:15px;">
        <div class="col-md-5">
            <label>Bairro: </label>
            <asp:RequiredFieldValidator ID="rfvBairro" ControlToValidate="txtBairro" 
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtBairro" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-5">
            <label>Cidade: </label>
            <asp:RequiredFieldValidator ID="rfvCidade" ControlToValidate="txtCidade" 
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtCidade" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>UF: </label>
            <asp:RequiredFieldValidator ID="rfvUF" ControlToValidate="txtUF" 
                ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtUF" runat="server" MaxLength="2" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top:15px;">
        <div class="col-md-12 text-right">
            <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click"/>
        </div>
    </div>
    <div class="row" style="margin-top:15px;">
        <div class="col-md-12 text-right">
            <asp:label ID="lblResultado" runat="server" CssClass="text-success"></asp:label> 
        </div>
    </div>
</asp:Content>