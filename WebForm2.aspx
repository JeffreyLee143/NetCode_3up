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
            Name: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="160px" TextMode="MultiLine" Width="255px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" Height="21px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" />

            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
