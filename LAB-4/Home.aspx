<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lab4_task2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            background-color: #99FF99;
        }
        .auto-style2 {
            width: 290px;
        }
        .auto-style3 {
            width: 290px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style5 {
            width: 290px;
            height: 28px;
        }
        .auto-style6 {
            height: 28px;
        }
        .auto-style7 {
            width: 290px;
            height: 31px;
        }
        .auto-style8 {
            height: 31px;
        }
        .auto-style9 {
            width: 50%;
            background-color: #FFFFCC;
        }
        .auto-style10 {
            width: 233px;
        }
        .auto-style11 {
            width: 233px;
            height: 25px;
        }
        .auto-style12 {
            width: 290px;
            height: 36px;
        }
        .auto-style13 {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Home page<br />
            <br />
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style3">Full Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="fnamerequire" runat="server" ControlToValidate="fname" EnableClientScript="False" ErrorMessage="Full Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">age</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="age" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" EnableClientScript="False" ErrorMessage="Range not valid" ForeColor="Red" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="agerequire" runat="server" ControlToValidate="age" EnableClientScript="False" ErrorMessage="Age require" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">password</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="passwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="passwordrequire" runat="server" ControlToValidate="passwd" EnableClientScript="False" ErrorMessage="Require" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">confirm password</td>
                    <td>
                        <asp:TextBox ID="passwd2" runat="server" OnTextChanged="TextBox4_TextChanged" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="passwd" ControlToValidate="passwd2" EnableClientScript="False" ErrorMessage="Password not match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">gender</td>
                    <td class="auto-style8">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem Value="m">Male</asp:ListItem>
                            <asp:ListItem Value="f">Female</asp:ListItem>
                            <asp:ListItem Value="nf">Prefere not to say</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="genderrequire" runat="server" ControlToValidate="RadioButtonList1" EnableClientScript="False" ErrorMessage="Gender Require" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">mobile number</td>
                    <td>
                        <asp:TextBox ID="number" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="number" EnableClientScript="False" ErrorMessage="Invalid mobile Number" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="mobilerequire" runat="server" ControlToValidate="number" EnableClientScript="False" ErrorMessage="Require" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">hobbies</td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem Value="reading">Reading</asp:ListItem>
                            <asp:ListItem Value="trawelling">Trawelling</asp:ListItem>
                            <asp:ListItem Value="dancing">Dancing</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">state</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Value="-1">select</asp:ListItem>
                            <asp:ListItem Value="gj">Gujarat</asp:ListItem>
                            <asp:ListItem Value="mh">Maharastra</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="staterequire" runat="server" ControlToValidate="DropDownList1" EnableClientScript="False" ErrorMessage="Require" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">city</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="DropDownList2" runat="server">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="cityrequire" runat="server" ControlToValidate="DropDownList2" EnableClientScript="False" ErrorMessage="Require" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">pan number</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="pnumber" runat="server"></asp:TextBox>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="pnumber" EnableClientScript="False" ErrorMessage="PanNumber invalid" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="panrequire" runat="server" ControlToValidate="pnumber" EnableClientScript="False" ErrorMessage="Require" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="reg" runat="server" OnClick="reg_Click" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">image page</td>
                    <td>
                        <asp:Button ID="img" runat="server" Text="View" OnClick="img_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <table align="center" class="auto-style9">
            <tr>
                <td class="auto-style10">FUll Name</td>
                <td>
                    <asp:Label ID="NameL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">age</td>
                <td>
                    <asp:Label ID="AgeL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">gender</td>
                <td class="auto-style4">
                    <asp:Label ID="GenderL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">mobile number</td>
                <td class="auto-style4">
                    <asp:Label ID="MobileL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">hobbies</td>
                <td class="auto-style4">
                    <asp:Label ID="HobbieL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">state</td>
                <td>
                    <asp:Label ID="StateL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">city</td>
                <td class="auto-style4">
                    <asp:Label ID="CityL" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">pan number</td>
                <td>
                    <asp:Label ID="PanL" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
