<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StringMetodları.aspx.cs" Inherits="WebApplication6.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="KARAKTER UZUNLUĞU" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="BÜYÜK HARF" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="KÜÇÜK HARF" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="BİRLEŞTİR" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="f string" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="kelime index" />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="index verilen karakteri bulma" />
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="SubString" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="butgem bursa ticaret ve sanayii odası eğitim vakfı"></asp:Label>
        </p>
    </form>
</body>
</html>
