<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project2.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 620px; top: 88px; position: absolute" Text="Look Up Classes"></asp:Label>
        <asp:LinkButton ID="linkHome" runat="server" style="z-index: 1; left: 254px; top: 101px; position: absolute" PostBackUrl="~/CourseRegistration.aspx">Home</asp:LinkButton>
        <asp:TextBox ID="txtStudentID" runat="server" style="z-index: 1; left: 616px; top: 169px; position: absolute; width: 205px; right: 683px"></asp:TextBox>
        <asp:Label ID="lblStudID" runat="server" style="z-index: 1; left: 534px; top: 169px; position: absolute" Text="Student ID"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 538px; top: 211px; position: absolute" Text="Day Code"></asp:Label>
        <asp:DropDownList runat="server" style="z-index: 1; left: 617px; top: 135px; position: absolute; width: 204px; height: 19px" ID="dropDept" DataSourceID="SqlDataSource1" DataTextField="DepartmentID" DataValueField="DepartmentID">
            <asp:ListItem Value="*">All Departments</asp:ListItem>
            <asp:ListItem Value="ENG">English</asp:ListItem>
            <asp:ListItem Value="MAT">Math</asp:ListItem>
            <asp:ListItem Value="CIS">Computer Science</asp:ListItem>
            <asp:ListItem Value="LIB">Liberal Arts</asp:ListItem>
            <asp:ListItem Value="POL">Political Science</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FA14_3342_tud03191ConnectionString %>" SelectCommand="SELECT [DepartmentID] FROM [Department]"></asp:SqlDataSource>
        <p>
            <asp:Button ID="btnCourseSearch" runat="server" style="z-index: 1; left: 634px; top: 252px; position: absolute" Text="Search Courses" OnClick="btnCourseSearch_Click" />
        </p>
        <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 379px; top: 308px; position: absolute; height: 133px; width: 612px">
            <Columns>
                <asp:BoundField DataField="CRN" HeaderText="CRN" />
                <asp:BoundField DataField="CourseTitle" HeaderText="Course" />
                <asp:BoundField DataField="DepartmentID" HeaderText="Department" />
                <asp:BoundField DataField="Section" HeaderText="Section" />
                <asp:BoundField DataField="Professor" HeaderText="Professor" />
                <asp:BoundField DataField="DayCode" HeaderText="Day" />
                <asp:BoundField DataField="TimeCode" HeaderText="Time" />
                <asp:BoundField DataField="CreditHours" HeaderText="Credit Hours" />
                <asp:BoundField DataField="NumberSeatsAvailable" HeaderText="Seats Available" />
                <asp:TemplateField HeaderText="Register">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkRegister" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                <asp:CheckBox ID="chkRegister" runat="server" />
            </EmptyDataTemplate>
        </asp:GridView>
        <asp:DropDownList ID="dropDayCode" runat="server" style="z-index: 1; left: 621px; top: 207px; position: absolute; width: 203px">
            <asp:ListItem>Sunday</asp:ListItem>
            <asp:ListItem>Monday</asp:ListItem>
            <asp:ListItem>Tuesday</asp:ListItem>
            <asp:ListItem>Wednesday</asp:ListItem>
            <asp:ListItem>Thursday</asp:ListItem>
            <asp:ListItem>Friday</asp:ListItem>
            <asp:ListItem>Saturday</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="z-index: 1; left: 1139px; top: 372px; position: absolute; height: 33px; width: 108px" Text="Register" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 572px; top: 282px; position: absolute; width: 307px"></asp:Label>
        <asp:CheckBox ID="chkSelectAllDept" runat="server" style="z-index: 1; left: 848px; top: 135px; position: absolute" Text="Select All*" />
        <asp:Label ID="lblDept" runat="server" style="z-index: 1; left: 533px; top: 138px; position: absolute" Text="Department"></asp:Label>
        <asp:CheckBox ID="chkSelectAllDays" runat="server" style="z-index: 1; left: 852px; top: 206px; position: absolute" Text="Select All*" />
    </form>
</body>
</html>
