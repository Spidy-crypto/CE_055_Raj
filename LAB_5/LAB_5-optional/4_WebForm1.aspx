<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_WebForm1.aspx.cs" Inherits="LAB5_task4._4_WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            Name :-
            <asp:TextBox ID="uname" runat="server" OnTextChanged="uname_TextChanged"></asp:TextBox>
        </p>
        <p>
            city :-&nbsp; <asp:TextBox ID="city" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/4_WebForm2.aspx" Text="Submit" />
        </p>
    </form>
</body>
</html>
