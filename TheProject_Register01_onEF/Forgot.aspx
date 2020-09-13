<%@ Page Language="C#" Async="true" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="Forgot.aspx.cs" Inherits="TheProject_Register01_onEF.Forgot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            Введите свой логин:<br />  
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Отправить сообщение на email" OnClick="Button1_ClickAsync" /><br />
            <asp:Label ID="LabelError" runat="server" Text="Такого логина не существует" ForeColor="Red" Visible="false"></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Операция прошла успешно" ForeColor="Green" Visible="false"></asp:Label><br />
            </asp:PlaceHolder>
            <br />
            <br />
            <asp:PlaceHolder ID="PlaceHolder2" runat="server" Visible ="false">
            Введите полученный код: <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" Text="Отправить" OnClick="Button3_Click"/>
                <asp:Label ID="Label1" runat="server" Text="Неверный код" ForeColor="Red" Visible="false"></asp:Label><br />
                <asp:Label ID="Label2" runat="server" Text="Операция прошла успешно" ForeColor="Green" Visible="false"></asp:Label><br />
                <asp:Button ID="Button2" runat="server" Text="Перейти на страницу входа" Visible="false" OnClick="Button2_Click" />
            </asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
