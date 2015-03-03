<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btnAddRealtor" runat="server" OnClick="btnAddRealtor_Click" Text="Add/Edit Realtor & View Requests" />
        <p>
            <asp:Button ID="btnAddHome" runat="server" OnClick="btnAddHome_Click" Text="Add/Edit Homes" />
        </p>
        <p>
            <asp:Button ID="btnSearchHome" runat="server" OnClick="btnSearchHome_Click" Text="Search All Homes" />
        </p>
    </form>
</body>
</html>
