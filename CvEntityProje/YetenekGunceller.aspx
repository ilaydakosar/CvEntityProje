﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGunceller.aspx.cs" Inherits="CvEntityProje.YetenekGunceller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <h4>YETENEK GÜNCELLEME SAYFASI</h4>
    <br />
 

    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Güncelle" OnClick="Button1_Click"  />
</asp:Content>
