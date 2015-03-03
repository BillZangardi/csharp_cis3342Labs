<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEditRealtors.aspx.cs" Inherits="Project_3.AddEditRealtors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" /><br /><br />
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="lblCompany" runat="server" Text="Company:"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="txtCompany" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="lblPhone" runat="server" Text="Phone Number:"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnAddRealtor" runat="server" Text="Add Realtor" OnClick="btnAddRealtor_Click" /><br /><br />
            <asp:Label ID="lblRealtorId" runat="server" Text=""></asp:Label><br /><br />
        </p>
        <asp:GridView ID="gvRealtors" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvRealtors_SelectedIndexChanged" AllowPaging="True" PageSize="5" OnPageIndexChanging="gvRealtors_PageIndexChanging" OnRowCancelingEdit="gvRealtors_RowCancelingEdit"  OnRowEditing="gvRealtors_RowEditing" OnRowUpdating="gvRealtors_RowUpdating" OnRowDeleting="gvRealtors_RowDeleting" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="true"/>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Company" HeaderText="Company" />
                <asp:BoundField DataField="PhoneNum" HeaderText="Phone" />
                <asp:CommandField ButtonType="Button" HeaderText="View Listing Requests" ShowCancelButton="False" ShowSelectButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
    </div>
        <asp:GridView ID="gvShowingRequests" runat="server">
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
