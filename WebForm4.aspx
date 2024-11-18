<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PID<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            PNAME<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            PTYPE<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            PRICE<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
