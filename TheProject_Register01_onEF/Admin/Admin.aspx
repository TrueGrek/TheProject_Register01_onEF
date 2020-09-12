<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="TheProject_Register01_onEF.Admin.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="../Image/74370.png" />
    <%//here will be realization udate table and give roles users %>
    <h1>Добро пожаловать, <%Membership.GetUser().UserName.ToString();%></h1>
    <br />
    <h2>На этой странице ты имеешь функционал, доступный только админам</h2>

                <br class="mb-3"/>
                <h3>Добавление пользователю права на домен</h3>
                Login:
                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox><br />
                Domen(только существующие):<br/>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="Domens" DataValueField="Domens">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Domens]"></asp:SqlDataSource>
                <br class="mb-3"/>
                
                <asp:Button ID="Button1" runat="server" Text="Добавить" CssClass="btn-success" OnClick="Button1_Click"/><br />
                <asp:Label ID="Label1" Visible="false" runat="server" Text="Операция прошла успешно" ForeColor="#33CC33"></asp:Label><br />
                <asp:Label ID="lableErrorHave" runat="server" ForeColor="Orange" Text="У пользователя уже есть права на этот домен"></asp:Label><br />
                <asp:Label ID="lableErrorHaveNotUser" runat="server" ForeColor="OrangeRed" Text="Такого пользователя нет в базе"></asp:Label><br />
    <br />
                <h3>Удаление прав на домен</h3>
                Login:
                <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"></asp:TextBox><br />
                Domen(только существующие):<br/>
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3" DataTextField="Domens" DataValueField="Domens">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Domens]"></asp:SqlDataSource>
                <br class="mb-3"/>
                
                <asp:Button ID="Button5" runat="server" Text="Удалить" CssClass="btn-success" OnClick="Button5_Click"/><br />
                <asp:Label ID="Label2" Visible="false" runat="server" Text="Операция прошла успешно" ForeColor="#33CC33"></asp:Label><br />
                <asp:Label ID="Label3" runat="server" Visible="false" ForeColor="Orange" Text="У пользователя уже нет прав на этот домен"></asp:Label><br />
                <asp:Label ID="Label4" runat="server" Visible="false" ForeColor="OrangeRed" Text="Такого пользователя нет в базе"></asp:Label><br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Таблица пользователей" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Таблица доменов" OnClick="Button3_Click" />
</asp:Content>

