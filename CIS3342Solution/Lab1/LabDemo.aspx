<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabDemo.aspx.cs" Inherits="Lab1.LabDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnProccess" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 136px; top: 293px; position: absolute" Text="Submit Form For Processing" />
            <asp:Label ID="lblDisplay" runat="server" style="z-index: 1; left: 237px; top: 225px; position: absolute" Text="Enter"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtInput" runat="server" Height="16px" style="z-index: 1; left: 137px; top: 259px; position: absolute; width: 241px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
