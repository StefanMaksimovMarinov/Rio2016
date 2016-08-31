<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="MVCBlog.Views.Search_Engine.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/Search.css" rel="stylesheet" />
</head>
<body class="body-posts2">
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="margin-left: 8px; margin-top: 0px" Text="Търсене" Width="80px" />
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="Body" HeaderText="Body" SortExpression="Body" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Title], [Body] FROM [Posts] WHERE (([Title] LIKE '%' + @Title + '%') AND ([Body] LIKE '%' + @Body + '%'))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="Title" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" Name="Body" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
    </form>
</body>
</html>
