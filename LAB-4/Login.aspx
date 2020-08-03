<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab4_task2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            background-color: #FFFFCC;
        }
        .auto-style2 {
            width: 241px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Login Form<br />
            <br />
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">Username :-</td>
                    <td>
                        <asp:TextBox ID="uname" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="unmaecheck" runat="server" ControlToValidate="uname" EnableClientScript="False" ErrorMessage="Invalid Username" ForeColor="Red" ValueToCompare="admin"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">PassWord:-</td>
                    <td>
                        <asp:TextBox ID="upass" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="upasscheck" runat="server" ControlToValidate="upass" EnableClientScript="False" ErrorMessage="Invalid password" ForeColor="Red" ValueToCompare="admin"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="ulogin" runat="server" OnClick="ulogin_Click" Text="Login" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Label ID="IC" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
            </strong>
        </div>
    </form>
</body>
</html>
