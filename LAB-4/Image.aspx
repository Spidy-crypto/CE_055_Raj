<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="Lab4_task2.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Image
            <br />
            <br />
            <asp:Button ID="view" runat="server" Text="View" OnClick="view_Click" />
            <br />
            <asp:Image ID="img1" runat="server" Height="150px" ImageUrl="~/Images/Image1.jpg" Visible="false" />
            <br />
        </div>
    </form>
</body>
</html>
