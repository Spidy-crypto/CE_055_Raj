<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Lab7_task4.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Id :-&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="Submit" runat="server" Text="Delete" OnClick="Submit_Click" style="height: 28px" />
            <br />
        </div>
    </form>
</body>
</html>
