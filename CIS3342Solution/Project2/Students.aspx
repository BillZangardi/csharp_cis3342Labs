<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Project2.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 27px; top: 92px; position: absolute" Text="Add Student"></asp:Label>
        <asp:TextBox ID="txtStudName" runat="server" style="z-index: 1; left: 76px; top: 142px; position: absolute; width: 171px"></asp:TextBox>
        <asp:Label ID="lblStudName" runat="server" style="z-index: 1; left: 12px; top: 144px; position: absolute; right: 1460px;" Text="Name: "></asp:Label>
        <asp:Label ID="lblStudID" runat="server" Font-Size="X-Large" style="z-index: 1; left: 11px; top: 224px; position: absolute; width: 278px"></asp:Label>
        <asp:LinkButton ID="linkHome" runat="server" PostBackUrl="~/CourseRegistration.aspx" style="z-index: 1; left: 29px; top: 44px; position: absolute">Home</asp:LinkButton>
        <asp:Label ID="lblMajor" runat="server" style="z-index: 1; left: 15px; top: 183px; position: absolute" Text="Major: "></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtStudMajor" runat="server" style="z-index: 1; left: 78px; top: 181px; position: absolute; width: 166px"></asp:TextBox>
        <asp:Label ID="lblRosterName" runat="server" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 497px; top: 207px; position: absolute"></asp:Label>
        <asp:GridView ID="gvStudentRoster" runat="server" style="z-index: 1; left: 486px; top: 267px; position: absolute; height: 133px; width: 411px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
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
        <p>
            &nbsp;</p>
        <asp:GridView ID="gvTuition" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 792px; top: 95px; position: absolute; height: 72px; width: 231px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="TuitionOwed" HeaderText="Tution Owed" />
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
        <p>
            <asp:Button ID="btnAddStud" runat="server" OnClick="btnAddStud_Click1" style="z-index: 1; left: 276px; top: 154px; position: absolute; width: 122px" Text="Add" />
        </p>
        <asp:GridView ID="gvStudents" runat="server" style="z-index: 1; left: 8px; top: 264px; position: absolute; height: 133px; width: 377px" AllowPaging="True" PageSize="5" OnPageIndexChanging="gvStudents_PageIndexChanging" AutoGenerateColumns="False" OnSelectedIndexChanged="gvStudents_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="StudentID" HeaderText="Student I.D." />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="TuitionOwed" HeaderText="Tuition Owed" />
                <asp:BoundField DataField="Major" HeaderText="Major" />
                <asp:CommandField ButtonType="Button" HeaderText="View Roster" ShowCancelButton="False" ShowSelectButton="True" />
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
    </form>
</body>
</html>
