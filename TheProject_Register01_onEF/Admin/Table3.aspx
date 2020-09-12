<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Table3.aspx.cs" Inherits="TheProject_Register01_onEF.Admin.Table3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="JustId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="JustId" HeaderText="JustId" InsertVisible="False" ReadOnly="True" SortExpression="JustId" />
                    <asp:BoundField DataField="IdUser" HeaderText="IdUser" SortExpression="IdUser" />
                    <asp:BoundField DataField="Domens" HeaderText="Domens" SortExpression="Domens" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [Tables]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
