<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEditHomes.aspx.cs" Inherits="Project_3.AddEditHomes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Realtor ID"></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropRealtor" runat="server" DataSourceID="SqlDataSource1" DataTextField="Id"></asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Button ID="btnViewHouses" runat="server" Text="View Current House Listings" OnClick="btnViewHouses_Click" /><br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="dropState" runat="server">
            <asp:ListItem Value="AL">Alabama</asp:ListItem>
            <asp:ListItem Value="AK">Alaska</asp:ListItem>
            <asp:ListItem Value="AZ">Arizona</asp:ListItem>
            <asp:ListItem Value="AR">Arkansas</asp:ListItem>
            <asp:ListItem Value="CA">California</asp:ListItem>
            <asp:ListItem Value="CO">Colorado</asp:ListItem>
            <asp:ListItem Value="CT">Connecticut</asp:ListItem>
            <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
            <asp:ListItem Value="DE">Delaware</asp:ListItem>
            <asp:ListItem Value="FL">Florida</asp:ListItem>
            <asp:ListItem Value="GA">Georgia</asp:ListItem>
            <asp:ListItem Value="HI">Hawaii</asp:ListItem>
            <asp:ListItem Value="ID">Idaho</asp:ListItem>
            <asp:ListItem Value="IL">Illinois</asp:ListItem>
            <asp:ListItem Value="IN">Indiana</asp:ListItem>
            <asp:ListItem Value="IA">Iowa</asp:ListItem>
            <asp:ListItem Value="KS">Kansas</asp:ListItem>
            <asp:ListItem Value="KY">Kentucky</asp:ListItem>
            <asp:ListItem Value="LA">Louisiana</asp:ListItem>
            <asp:ListItem Value="ME">Maine</asp:ListItem>
            <asp:ListItem Value="MD">Maryland</asp:ListItem>
            <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
            <asp:ListItem Value="MI">Michigan</asp:ListItem>
            <asp:ListItem Value="MN">Minnesota</asp:ListItem>
            <asp:ListItem Value="MS">Mississippi</asp:ListItem>
            <asp:ListItem Value="MO">Missouri</asp:ListItem>
            <asp:ListItem Value="MT">Montana</asp:ListItem>
            <asp:ListItem Value="NE">Nebraska</asp:ListItem>
            <asp:ListItem Value="NV">Nevada</asp:ListItem>
            <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
            <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
            <asp:ListItem Value="NM">New Mexico</asp:ListItem>
            <asp:ListItem Value="NY">New York</asp:ListItem>
            <asp:ListItem Value="NC">North Carolina</asp:ListItem>
            <asp:ListItem Value="ND">North Dakota</asp:ListItem>
            <asp:ListItem Value="OH">Ohio</asp:ListItem>
            <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
            <asp:ListItem Value="OR">Oregon</asp:ListItem>
            <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
            <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
            <asp:ListItem Value="SC">South Carolina</asp:ListItem>
            <asp:ListItem Value="SD">South Dakota</asp:ListItem>
            <asp:ListItem Value="TN">Tennessee</asp:ListItem>
            <asp:ListItem Value="TX">Texas</asp:ListItem>
            <asp:ListItem Value="UT">Utah</asp:ListItem>
            <asp:ListItem Value="VT">Vermont</asp:ListItem>
            <asp:ListItem Value="VA">Virginia</asp:ListItem>
            <asp:ListItem Value="WA">Washington</asp:ListItem>
            <asp:ListItem Value="WV">West Virginia</asp:ListItem>
            <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
            <asp:ListItem Value="WY">Wyoming</asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <asp:Label ID="lblListingPrice" runat="server" Text="Listing Price:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtListingPrice" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblAvail" runat="server" Text="Availability:"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="dropAvail" runat="server">
            <asp:ListItem Value="SOLD">SOLD</asp:ListItem>
            <asp:ListItem Value="For Sale">For Sale</asp:ListItem>
            <asp:ListItem Value="Foreclosure">Foreclosure</asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <asp:Label ID="lblSqFt" runat="server" Text="Square Feet:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtSqFt" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblBaths" runat="server" Text="Baths:"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="dropBaths" runat="server">
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
            <asp:ListItem Value="5">5</asp:ListItem>
            <asp:ListItem Value="6">6</asp:ListItem>
            <asp:ListItem Value="7">7</asp:ListItem>
            <asp:ListItem Value="8">8</asp:ListItem>
            <asp:ListItem Value="9">9</asp:ListItem>
            <asp:ListItem Value="10">10</asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <asp:Label ID="lblBeds" runat="server" Text="Beds:"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="dropBeds" runat="server">
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
            <asp:ListItem Value="5">5</asp:ListItem>
            <asp:ListItem Value="6">6</asp:ListItem>
            <asp:ListItem Value="7">7</asp:ListItem>
            <asp:ListItem Value="8">8</asp:ListItem>
            <asp:ListItem Value="9">9</asp:ListItem>
            <asp:ListItem Value="10">10</asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <asp:Label ID="lblType" runat="server" Text="Type:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtType" runat="server"></asp:TextBox><br /><br />
        <br /><br />
        
        <asp:Button ID="btnAddHouses" runat="server" Text="Add House" OnClick="btnAddHouses_Click" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FA14_3342_tud03191ConnectionString %>" SelectCommand="SELECT [Id] FROM [Realtor]"></asp:SqlDataSource>
 
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
 
    
    </div>
        <asp:GridView ID="gvHouseListings" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvHouseListings_SelectedIndexChanged" AllowPaging="True" PageSize="5" OnPageIndexChanging="gvHouseListings_PageIndexChanging" OnRowCancelingEdit="gvHouseListings_RowCancelingEdit"  OnRowEditing="gvHouseListings_RowEditing" OnRowUpdating="gvHouseListings_RowUpdating" OnRowDeleting="gvHouseListings_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="true"/>
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="ListingPrice" HeaderText="Listing Price" />
                <asp:BoundField DataField="SquareFeet" HeaderText="Square Feet" />
                <asp:BoundField DataField="Availability" HeaderText="Availability" />
                <asp:BoundField DataField="Beds" HeaderText="Beds" />
                <asp:BoundField DataField="Baths" HeaderText="Baths" />
                <asp:BoundField DataField="RealtorId" HeaderText="RealtorID" ReadOnly="true"/>
                <asp:BoundField DataField="Type" HeaderText="Type" />
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
    </form>
</body>
</html>
