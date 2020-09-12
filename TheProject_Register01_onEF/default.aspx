<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TheProject_Register01_onEF._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous"/>
    <link rel="canonical" href="https://getbootstrap.com/docs/4.5/examples/sign-in/">
    <link href="signin.css" rel="stylesheet">

        <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>

</head>
<body class="text-center">
    <form class="form-signin" id="form1" runat="server">
  <img class="mb-4" src="doge.gif" alt="" width="100" height="100">
  <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
    
        <asp:Login ID="Login1" DestinationPageUrl="~/Table.aspx" runat="server"></asp:Login>

        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/defaultReg.aspx">Ещё нет аккаунта?</asp:HyperLink><br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Forgot.aspx">Забыли пароль?</asp:HyperLink>
        <asp:Label ID="Label1" Visible="false" runat="server" Text="Неправильно набран логин или пароль" ForeColor="Red"></asp:Label>
  <p class="mt-5 mb-3 text-muted">&copy; 2020</p>
</form>
</body>
</html>
