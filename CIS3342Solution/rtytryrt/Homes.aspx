<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homes.aspx.cs" Inherits="Project_3.Homes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
        </p>
        <asp:Label ID="Label5" runat="server" Text="*CHECK SELECT BOXES AND ENTER SEARCH CRITERIA*"></asp:Label><br />
        <asp:Label ID="Label1" runat="server" Text="City"></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropCity" runat="server"></asp:DropDownList>
        <asp:CheckBox ID="chkCity" runat="server" /><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="State"></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropState" runat="server"></asp:DropDownList>
        <asp:CheckBox ID="chkState" runat="server" /><br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Type"></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropType" runat="server">
        </asp:DropDownList>
       
        <asp:CheckBox ID="chkType" runat="server" /><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Price Maximum"></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropPriceMax" runat="server">
            <asp:ListItem>10000</asp:ListItem>
            <asp:ListItem>25000</asp:ListItem>
            <asp:ListItem>50000</asp:ListItem>
            <asp:ListItem>100000</asp:ListItem>
            <asp:ListItem>150000</asp:ListItem>
            <asp:ListItem>250000</asp:ListItem>
            <asp:ListItem>500000</asp:ListItem>
            <asp:ListItem>750000</asp:ListItem>
            <asp:ListItem>1000000</asp:ListItem>
        </asp:DropDownList><asp:CheckBox ID="chkPrice" runat="server" /><br /><br />
        <asp:Label ID="Label6" runat="server" Text="Beds Min."></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropBeds" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:DropDownList><asp:CheckBox ID="chkBeds" runat="server" /><br /><br />
        <asp:Label ID="Label7" runat="server" Text="Baths Min."></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropBaths" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:DropDownList><asp:CheckBox ID="chkBaths" runat="server" /><br /><br />
        <asp:Label ID="Label8" runat="server" Text="Square Feet Min."></asp:Label>&nbsp;&nbsp;<asp:DropDownList ID="dropSqFt" runat="server">
            <asp:ListItem>500</asp:ListItem>
            <asp:ListItem>750</asp:ListItem>
            <asp:ListItem>1000</asp:ListItem>
            <asp:ListItem>1500</asp:ListItem>
            <asp:ListItem>2500</asp:ListItem>
        </asp:DropDownList><asp:CheckBox ID="chkSqFt" runat="server" /><br /><br />
        <asp:Button ID="btnSearchHomes" runat="server" Text="Search All Homes" OnClick="btnSearchHomes_Click" /><br /><br />

        <asp:Label ID="lblSearchQuery" runat="server" Text="ALL LISTINGS"></asp:Label>
        
        <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" OnPageIndexChanging="gvHomes_PageIndexChanging" >
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="Type" HeaderText="Type" />
                <asp:BoundField DataField="ListingPrice" HeaderText="Price" />
                <asp:BoundField DataField="Beds" HeaderText="Beds" />
                <asp:BoundField DataField="Baths" HeaderText="Baths" />
                <asp:BoundField DataField="SquareFeet" HeaderText="Square Feet" />
                <asp:BoundField DataField="Availability" HeaderText="Availability" />
                <asp:BoundField DataField="RealtorId" HeaderText="RealtorId" />
                <asp:TemplateField HeaderText="Request Showing">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkRequest" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
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
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblPhone" runat="server" Text="Phone:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="btnViewRequest" runat="server" Text="Request Showing" OnClick="btnViewRequest_Click" />
    </form>
</body>
</html>
