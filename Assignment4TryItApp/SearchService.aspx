<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchService.aspx.cs" Inherits="Assignment4TryItApp.SearchService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <div class="col-md-4">
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Enter URL of the XML :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="329px" style="margin-left: 6px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Enter key name for which the content is needed : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="329px" Height="20px" style="margin-left: 5px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Click to Verify" Width="265px" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
