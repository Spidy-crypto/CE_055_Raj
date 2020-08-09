<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Login.aspx.cs" Inherits="LAB5_task2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top:20px;;
            width: 70%;
            background-color: #FFFF99;
        }
        .auto-style2 {
            width: 247px;
        }
        #l{
            margin-left:50%;
            font-size:20px;
            font-weight:bold;
            margin-top:20px;
            color:blue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="l" runat="server" Text="LogIn"></asp:Label>
            <br />
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">Username:-</td>
                    <td>
                        <asp:TextBox ID="uname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="urequired" runat="server" ControlToValidate="uname" EnableClientScript="False" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password:-</td>
                    <td>
                        <asp:TextBox ID="passwd" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="passwdrequired" runat="server" ControlToValidate="passwd" EnableClientScript="False" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="button" runat="server" OnClick="button_Click" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
