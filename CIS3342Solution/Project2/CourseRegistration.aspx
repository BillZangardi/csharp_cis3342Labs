<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseRegistration.aspx.cs" Inherits="Project2.CourseRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <br />
        <br />
        <br />
        <asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 610px; top: 108px; position: absolute; width: 260px" Text="Course Registration"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnToCourse" runat="server" OnClick="btnToCourse_Click" style="z-index: 1; left: 594px; top: 159px; position: absolute; width: 279px; height: 62px" Text="Add/Edit Courses" />
        </p>
        <asp:Button ID="btnAddDelStud" runat="server" OnClick="btnAddDelStud_Click" style="z-index: 1; top: 244px; position: absolute; width: 280px; left: 591px; height: 61px" Text="Add Student &amp; View Roster" />
        <asp:Button ID="btnRegisterStudent" runat="server" OnClick="btnRegisterStudent_Click" style="z-index: 1; left: 592px; top: 337px; position: absolute; width: 281px; height: 70px" Text="Look Up Classes and Registration" />
    </form>
</body>
</html>
