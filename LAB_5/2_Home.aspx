<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Home.aspx.cs" Inherits="LAB5_task2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            background-color: #FFFFCC;
        }
        .auto-style2 {
            width: 218px;
        }
        #ulabel{
            margin-left:50%;
            font-size:20px;
            font-weight:bold;
            margin-top:20px;
            color:blue;
        }
        .auto-style3 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <br />
            <asp:Label ID="ulabel" runat="server"></asp:Label>
            <br />
            <br />
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">Category:-</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem>Electronics</asp:ListItem>
                            <asp:ListItem>books</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Choose Items:-</td>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="button1" runat="server" OnClick="Button1_Click" Text="Place Order" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
