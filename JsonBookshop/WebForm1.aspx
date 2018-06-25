<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JsonBookshop.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="bookIDLabel" runat="server" Text="BookID"></asp:Label>
&nbsp;
            <asp:TextBox ID="bookIDTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="titleLabel" runat="server" Text="Title"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="catIDLabel" runat="server" Text="CatID"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="catIDTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="isbnLabel" runat="server" Text="ISBN"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="isbnTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="authorLabel" runat="server" Text="Author"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="stockLabel" runat="server" Text="Stock"></asp:Label>
&nbsp;
            <asp:TextBox ID="stockTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="priceLabel" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="priceTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="synopsisLabel" runat="server" Text="Synopsis"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="synTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="swDiscLabel" runat="server" Text="SWdiscount"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="swdiscTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="finalPriceLabel" runat="server" Text="finalprice"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="finalpriceTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="submitBtn" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
