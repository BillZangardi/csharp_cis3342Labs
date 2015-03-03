<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPizzaShop.aspx.cs" Inherits="Project1.MyPizzaShop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
        }
        #txtName {
            z-index: 1;
            left: 332px;
            top: 30px;
            position: absolute;
            width: 146px;
        }
        #txtAddress {
            width: 152px;
            margin-left: 14px;
            z-index: 1;
            left: 317px;
            top: 70px;
            position: absolute;
        }
        #txtPhone {
            z-index: 1;
            left: 331px;
            top: 112px;
            position: absolute;
            width: 148px;
            right: 385px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblName" runat="server" Text="Name:" style="z-index: 1; left: 288px; top: 32px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" required="true"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address:" style="z-index: 1; left: 272px; position: absolute; top: 71px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" required="true"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPhone" runat="server" Text="Phone:" style="z-index: 1; left: 281px; top: 112px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" required="true"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="dropDelivery" runat="server" style="z-index: 1; left: 349px; top: 160px; position: absolute">
                <asp:ListItem>Pickup</asp:ListItem>
                <asp:ListItem>Delivery</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:GridView ID="gvPizzas" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvPizzas_SelectedIndexChanged" style="z-index: 1; left: 165px; top: 201px; position: absolute; height: 182px; width: 329px">
            <Columns>
                <asp:TemplateField HeaderText="Select Pizza">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="PizzaType" HeaderText="Pizza Type"></asp:BoundField>
                <asp:BoundField DataField="BasePrice" HeaderText="Price"></asp:BoundField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Size">
                    <ItemTemplate>
                        <asp:DropDownList ID="dropSize" runat="server">
                            <asp:ListItem Value="Small">Small</asp:ListItem>
                            <asp:ListItem Value="Medium">Medium  (+$1.50)</asp:ListItem>
                            <asp:ListItem Value="Large">Large (+$2.25)</asp:ListItem>
                            <asp:ListItem Value="X-Large">X-Large  (+$3.00)</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <p>
            <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" style="z-index: 1; left: 362px; top: 401px; position: absolute" />
        </p>
        <asp:Label ID="lblOrder" runat="server" style="z-index: 1; left: 29px; top: 441px; position: absolute"></asp:Label>
        <asp:GridView ID="gvOrder" runat="server" AutoGenerateColumns="False" ShowFooter="True" style="z-index: 1; left: 24px; top: 500px; position: absolute; height: 145px; width: 384px">
            <Columns>
                <asp:BoundField DataField="PizzaType" HeaderText="PizzaType" />
                <asp:BoundField DataField="Size" HeaderText="Size" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="TotalCost" HeaderText="Total Cost" />
            </Columns>
        </asp:GridView>
        <p>
        <asp:Button ID="btnManager" runat="server" Text="Manager Report" OnClick="Button1_Click" style="z-index: 1; left: 429px; top: 401px; position: absolute" />
        </p>
        <asp:GridView ID="gvManager" runat="server" style="z-index: 1; left: 421px; top: 507px; position: absolute; height: 71px; width: 346px">
        </asp:GridView>
    </form>
</body>
</html>
