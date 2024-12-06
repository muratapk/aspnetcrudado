<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Duzelt.aspx.cs" Inherits="uygulamalarasp.Duzelt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 324px;
        }
        .auto-style1 {
            width: 293px;
        }
        .auto-style2 {
            width: 348px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">Kullanıcı Adı</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox1" runat="server" Width="171px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Şifre</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox2" runat="server" Width="178px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="Düzelt" Width="90px" />
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
