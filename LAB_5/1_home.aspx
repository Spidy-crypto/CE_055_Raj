<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_home.aspx.cs" Inherits="Lab5_task1._1_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Home page<br />
            <br />
            Name :-
            <asp:TextBox ID="uname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uname" ErrorMessage="Required" ForeColor="Red" EnableClientScript="False"></asp:RequiredFieldValidator>
            <br />
            <br />
            State :-&nbsp;
            <asp:TextBox ID="state" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="state" ErrorMessage="Required" ForeColor="Red" EnableClientScript="False"></asp:RequiredFieldValidator>
            <br />
&nbsp;<br />
            city :-&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="city" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="city" ErrorMessage="Required" ForeColor="Red" EnableClientScript="False"></asp:RequiredFieldValidator>
            <br />
            <br />
            mobie_no :-
            <asp:TextBox ID="mno" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="mno" ErrorMessage="Required" ForeColor="Red" EnableClientScript="False"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="cc" runat="server"  Text="Create Cookie" OnClick="cc_Click" />
            <br />
            <br />
            <asp:Button ID="vc" runat="server" OnClick="vc_Click" Text="View cookie" />
        </div>
    </form>
</body>
</html>
