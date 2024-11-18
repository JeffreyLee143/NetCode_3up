<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="PType" DataValueField="PType">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:imConnectionString %>" SelectCommand="SELECT DISTINCT [PType] FROM [Table]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PId" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <EditItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" onClientClick="return confirm('Are you sure?')"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="PId" HeaderText="PId" ReadOnly="True" SortExpression="PId" />
                    <asp:BoundField DataField="PName" HeaderText="PName" SortExpression="PName" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="PType" HeaderText="PType" SortExpression="PType" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:imConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [PId] = @original_PId AND [PName] = @original_PName AND [Price] = @original_Price AND [PType] = @original_PType" InsertCommand="INSERT INTO [Table] ([PId], [PName], [Price], [PType]) VALUES (@PId, @PName, @Price, @PType)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [PId], [PName], [Price], [PType] FROM [Table] WHERE ([PType] = @PType)" UpdateCommand="UPDATE [Table] SET [PName] = @PName, [Price] = @Price, [PType] = @PType WHERE [PId] = @original_PId AND [PName] = @original_PName AND [Price] = @original_Price AND [PType] = @original_PType">
                <DeleteParameters>
                    <asp:Parameter Name="original_PId" Type="Int32" />
                    <asp:Parameter Name="original_PName" Type="String" />
                    <asp:Parameter Name="original_Price" Type="Int32" />
                    <asp:Parameter Name="original_PType" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="PId" Type="Int32" />
                    <asp:Parameter Name="PName" Type="String" />
                    <asp:Parameter Name="Price" Type="Int32" />
                    <asp:Parameter Name="PType" Type="Int32" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="PType" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="PName" Type="String" />
                    <asp:Parameter Name="Price" Type="Int32" />
                    <asp:Parameter Name="PType" Type="Int32" />
                    <asp:Parameter Name="original_PId" Type="Int32" />
                    <asp:Parameter Name="original_PName" Type="String" />
                    <asp:Parameter Name="original_Price" Type="Int32" />
                    <asp:Parameter Name="original_PType" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
