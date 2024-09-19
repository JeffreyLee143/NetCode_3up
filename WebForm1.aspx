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
            <asp:Label ID="Label1" runat="server" Text="三角形底"></asp:Label>
            <asp:TextBox ID="num1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="三角形高"></asp:Label>
            <asp:TextBox ID="num2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="計算" OnClick="Button1_Click"/>
            <br />
            三角形面積: <asp:Label ID="n4" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
