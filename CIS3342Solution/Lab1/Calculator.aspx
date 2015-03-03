<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Lab1.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
        <asp:DropDownList ID="dropOperators" runat="server">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem Value="/"></asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        <asp:Label ID="lblResult" runat="server" Text="="></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCalculate" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 79px; position: absolute" Text="Calculate" />
        </p>
    </form>
</body>
</html>
