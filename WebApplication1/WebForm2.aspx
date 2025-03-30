<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

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
            <asp:CheckBoxList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="true">M</asp:ListItem>
                <asp:ListItem Value="false">F</asp:ListItem>
            </asp:CheckBoxList>
            Skills<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>C++</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
