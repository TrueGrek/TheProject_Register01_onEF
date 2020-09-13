<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Table.aspx.cs" Inherits="TheProject_Register01_onEF.Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous"/>

</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container col-12">
            <div class="py-5 text-center ">
                <asp:Label ID="Label2" runat="server" Visible="true" Text="Общая таблица" Font-Size="X-Large"></asp:Label>
                <br />
                <asp:Button ID="Button2" runat="server" Text="Посмотреть таблицу всех пользователей" OnClick="Button2_Click" /><br />
                <asp:Label ID="Labeld" runat="server" Text="Здесь указаны доступные пользователю домены"></asp:Label>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="IdUser" HeaderText="IdUser" SortExpression="IdUser" />
                        <asp:BoundField DataField="Domens" HeaderText="Domens" SortExpression="Domens" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [IdUser], [Domens] FROM [Tables] WHERE ([IdUser] = @IdUser)">
                    <SelectParameters>
                        <asp:SessionParameter Name="IdUser" SessionField="idSS" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <br />
                
                У пользователя есть права на следующие домены: <br />
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                <%--Container.DataItem - один элемент источника данных, в данном случае типа string--%>
                <%# Container.DataItem %>
                <br />
            </ItemTemplate>
                </asp:Repeater>
                
                <asp:Literal ID="Literal1" runat="server" Text="На сервере сейчас: "></asp:Literal>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ChangePassword.aspx" >Изменить пароль</asp:HyperLink>
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Yandex" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="Gmail" OnClick="Button4_Click" />
                <asp:Button ID="Button6" runat="server" Text="Google" OnClick="Button6_Click" /><br />
                <asp:Button ID="Button5" runat="server" Text="Admin" OnClick="Button5_Click" />
                <asp:Label ID="Label1" Visible="false" runat="server" Text="У вас нет прав на этот домен"></asp:Label>
        </div>

    </form>
</body>
</html>
