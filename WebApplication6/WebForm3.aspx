<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication6.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="SAYI1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="SAYI2"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="MAX" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="MIN" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="KAREKÖK" Width="88px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="MUTLAK DEĞER" Width="138px" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="YUVARLA" />
        <div>
            <asp:Label ID="sonuc" runat="server" Text="SONUÇ"></asp:Label>
        </div>
    </form>
</body>
</html>
