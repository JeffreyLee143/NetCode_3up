<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Simple Calculator</h2></div>
        <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
        <asp:TextBox ID="num1" runat="server" Width="148px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
        <asp:TextBox ID="num2" runat="server" Width="148px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        <br />
        Result: <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
    </form>
</body>
</html>
