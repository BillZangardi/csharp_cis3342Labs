<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="Project2.Courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 531px; top: 50px; position: absolute" Text="Add/Edit Courses"></asp:Label>
        <asp:TextBox ID="txtCRN" runat="server" style="z-index: 1; left: 584px; top: 106px; position: absolute; width: 144px; bottom: 735px"></asp:TextBox>
        <asp:TextBox ID="txtMaxNumSeats" runat="server" style="z-index: 1; left: 574px; top: 371px; position: absolute; width: 154px" TabIndex="8"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtTimeCode" runat="server" style="z-index: 1; left: 574px; top: 334px; position: absolute; width: 153px" TabIndex="7"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtProfessor" runat="server" style="z-index: 1; left: 580px; top: 205px; position: absolute; width: 147px" TabIndex="3"></asp:TextBox>
            <asp:Label ID="lblCourse" runat="server" style="z-index: 1; left: 495px; top: 173px; position: absolute" Text="Course Title"></asp:Label>
        </p>
        <asp:TextBox ID="txtCourseTitle" runat="server" style="z-index: 1; left: 580px; top: 174px; position: absolute; width: 149px" TabIndex="2"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtSection" runat="server" style="z-index: 1; left: 580px; top: 236px; position: absolute; width: 147px" TabIndex="4"></asp:TextBox>
        </p>
        <asp:DropDownList ID="dropDept" runat="server" style="z-index: 1; left: 578px; top: 139px; position: absolute; width: 166px" DataSourceID="SqlDataSource" DataTextField="DepartmentID" DataValueField="DepartmentID">
            <asp:ListItem>MAT</asp:ListItem>
            <asp:ListItem>ENG</asp:ListItem>
            <asp:ListItem>CIS</asp:ListItem>
            <asp:ListItem>POL</asp:ListItem>
            <asp:ListItem>LIB</asp:ListItem>
            <asp:ListItem>KIN</asp:ListItem>
            <asp:ListItem>BIO</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:FA14_3342_tud03191ConnectionString %>" SelectCommand="SELECT [DepartmentID] FROM [Department]"></asp:SqlDataSource>
        <p>
            <asp:TextBox ID="txtCreditHours" runat="server" style="z-index: 1; left: 577px; top: 299px; position: absolute; width: 149px" TabIndex="6"></asp:TextBox>
        </p>
        <asp:LinkButton ID="linkHome" runat="server" PostBackUrl="~/CourseRegistration.aspx" style="z-index: 1; left: 195px; top: 63px; position: absolute">Home</asp:LinkButton>
        <asp:Label ID="lblProf" runat="server" style="z-index: 1; left: 514px; top: 206px; position: absolute; right: 940px" Text="Professor"></asp:Label>
        <asp:Label ID="lblMaxNumSeats" runat="server" style="z-index: 1; left: 481px; top: 370px; position: absolute" Text="Max. # Seats"></asp:Label>
        <asp:Label ID="lblDept" runat="server" style="z-index: 1; left: 482px; top: 142px; position: absolute" Text="Department ID"></asp:Label>
        <asp:Label ID="lblTimeCode" runat="server" style="z-index: 1; left: 498px; top: 336px; position: absolute" Text="Time Code"></asp:Label>
        <asp:Label ID="lblCRN" runat="server" style="z-index: 1; left: 541px; top: 108px; position: absolute; bottom: 736px" Text="CRN"></asp:Label>
        <asp:Label ID="lblCreditHours" runat="server" style="z-index: 1; left: 491px; top: 301px; position: absolute" Text="Credit Hours"></asp:Label>
        <asp:Label ID="lblDayCode" runat="server" style="z-index: 1; left: 503px; top: 267px; position: absolute; height: 19px" Text="Day Code"></asp:Label>
        <asp:Label ID="lblSection" runat="server" style="z-index: 1; left: 520px; top: 235px; position: absolute; right: 947px" Text="Section"></asp:Label>
        <asp:Button ID="btnAddCourse" runat="server" style="z-index: 1; left: 510px; top: 420px; position: absolute; width: 172px" Text="Add Course" OnClick="btnAddCourse_Click" />
        <asp:GridView ID="gvAllCourses" runat="server" style="z-index: 1; left: 24px; top: 499px; position: absolute; height: 133px; width: 187px; margin-right: 0px; margin-bottom: 0px;"  AllowPaging="True" PageSize="5" OnPageIndexChanging="gvAllCourses_PageIndexChanging" AutoGenerateColumns="False" OnRowCancelingEdit="gvAllCourses_RowCancelingEdit"  OnRowEditing="gvAllCourses_RowEditing" OnRowUpdating="gvAllCourses_RowUpdating" OnRowDeleting="gvAllCourses_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="CRN" HeaderText="CRN" readonly="true"/>
                <asp:BoundField DataField="CourseTitle" HeaderText="Course" />
                <asp:BoundField DataField="DepartmentID" HeaderText="Department I.D." />
                <asp:BoundField DataField="Section" HeaderText="Section" />
                <asp:BoundField DataField="Professor" HeaderText="Professor" />
                <asp:BoundField DataField="DayCode" HeaderText="Day Code" />
                <asp:BoundField DataField="TimeCode" HeaderText="Time Code" />
                <asp:BoundField DataField="CreditHours" HeaderText="Credit Hours" />
                <asp:BoundField DataField="NumberSeatsAvailable" HeaderText="Seats Avail" />
                <asp:BoundField DataField="MaximumSeats" HeaderText="Max. Seats" />
                <asp:CommandField AccessibleHeaderText="Edit" ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 566px; top: 395px; position: absolute"></asp:Label>
        <asp:Label ID="lblDisplay" runat="server" style="z-index: 1; left: 194px; top: 466px; position: absolute"></asp:Label>
        <asp:Label ID="lblDeptTitle" runat="server" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 1063px; top: 53px; position: absolute; height: 32px" Text="Add New Department"></asp:Label>
        <asp:TextBox ID="txtDeptName" runat="server" style="z-index: 1; left: 1156px; top: 105px; position: absolute; width: 177px"></asp:TextBox>
        <asp:TextBox ID="txtDeptID" runat="server" style="z-index: 1; left: 1157px; top: 144px; position: absolute; width: 174px"></asp:TextBox>
        <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; left: 1159px; top: 181px; position: absolute; width: 173px"></asp:TextBox>
        <asp:Label ID="lblDeptName" runat="server" style="z-index: 1; left: 1035px; top: 106px; position: absolute" Text="Department Name"></asp:Label>
        <asp:Label ID="lblDeptID" runat="server" style="z-index: 1; left: 972px; top: 144px; position: absolute" Text="Department ID (3 characters)"></asp:Label>
        <asp:Label ID="lblLocation" runat="server" style="z-index: 1; left: 1092px; top: 181px; position: absolute; right: 367px" Text="Location"></asp:Label>
        <asp:Button ID="btnAddDept" runat="server" OnClick="btnAddDept_Click" style="z-index: 1; left: 1158px; top: 239px; position: absolute; width: 117px" Text="Add Department" />
        <asp:Label ID="lblDeptError" runat="server" style="z-index: 1; left: 1122px; top: 204px; position: absolute; width: 379px"></asp:Label>
        <asp:DropDownList ID="dropDayCode" runat="server" style="z-index: 1; left: 579px; top: 267px; position: absolute; width: 171px">
            <asp:ListItem>Sunday</asp:ListItem>
            <asp:ListItem>Monday</asp:ListItem>
            <asp:ListItem>Tuesday</asp:ListItem>
            <asp:ListItem>Wednesday</asp:ListItem>
            <asp:ListItem>Thursday</asp:ListItem>
            <asp:ListItem>Friday</asp:ListItem>
            <asp:ListItem>Saturday</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
