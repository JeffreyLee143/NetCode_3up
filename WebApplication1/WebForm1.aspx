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
            Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Geder:<asp:RadioButton ID="RadioButton1" runat="server"  Text="M"/>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="F" />
            <br />
            Skills<br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C"/>
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Java"/>
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Python"/>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
