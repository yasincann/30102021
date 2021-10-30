<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Operatorler.aspx.cs" Inherits="WebApplication6.Operatorler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="SAYI 1"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="SAYI 2"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="TOPLA" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ÇIKAR" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="ÇARP" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="BÖL" />
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="sonuc" runat="server" Text="SONUÇ"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
