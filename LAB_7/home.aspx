<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="LAB7_task3.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:lightcoral;
        }
        .auto-style1 {
            margin-left: 600px;
        }
        .auto-style3 {
            margin-left: 640px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Enter ProductId</p>
        <p class="auto-style1">
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="180px"></asp:TextBox>
        </p>
        <p class="auto-style3">
            <asp:Button ID="Button1" runat="server" Height="39px" Text="Submit" Width="99px" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
