<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="defaultReg.aspx.cs" Inherits="TheProject_Register01_onEF.defaultReg" %>

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
  <h1 class="h3 mb-3 font-weight-normal">Create an account</h1>
        <asp:CreateUserWizard ID="CreateUserWizard1" ContinueDestinationPageUrl="~/default.aspx" OnCreatingUser="OnCreatedUser" runat="server" Answer="hi">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>

        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Уже есть аккаунт?</asp:HyperLink>
        
  <p class="mt-5 mb-3 text-muted">&copy; 2020</p>
        

</form>
</body>
</html>
