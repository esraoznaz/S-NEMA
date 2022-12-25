<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="İZLEYİCİ.aspx.cs" Inherits="SİNEMA.İZLEYİCİ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server" aria-pressed="undefined" aria-readonly="False">
        <table width="50%" border="1">
            <tr>
                <td colpasan="2" >İZLEYİCİ BİLGİSİ</td>
            </tr>
            <tr>
                <td>İSİM:</td>
                <td>
                    <asp:TextBox ID="txt_isim" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>SOYİSİM:</td>
                <td>
                    <asp:TextBox ID="txt_soyisim" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>YAŞ:</td>
                <td>
                    <asp:TextBox ID="txt_yas" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>FİLM TÜRÜ:</td>
                <td>
                     <asp:DropDownList ID="drpDow_filmTur" runat="server" >
                        <asp:ListItem Value="0">SECİNİZ</asp:ListItem>
                        <asp:ListItem Value="1">KORKU</asp:ListItem>
                        <asp:ListItem Value="2">KOMEDİ</asp:ListItem>
                        <asp:ListItem Value="3">GERİLİM</asp:ListItem>
                        <asp:ListItem Value="4">ÇİZGİ FİLM</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>FİLİM ADI:</td>
                <td>
                    <asp:TextBox ID="txt_filmAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>ÖGRENCİ</td>
                <td>
                    <asp:CheckBox ID="checkBox_ogr" runat="server" Text="Ögrenci"></asp:CheckBox>
                    
                </td>
            </tr>
            <tr>
                <td>ÖĞRENCİ= 25TL TAM= 50TL</td>
                <td>
                    <asp:Button ID="Button_biletAl" runat="server" Text="Bilet Al" OnClick="Button_biletAl_Click"></asp:Button>
                    <asp:Button ID="Button_biletİptal" runat="server" Text="Bilet İptal" OnClick="Button_biletİptal_Click"></asp:Button>
                </td>
            </tr>

            
        </table>
        <br />
        <br />
        <br />
        <table width="50%" border="1">
           
            <tr>
                <td>KORKU FİLMİ BAKİYESİ:</td>
                <td>
                    <asp:TextBox ID="txt_korkuBakiye" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>KOMEDİ FİLİMİ BAKİYESİ:</td>
                <td>
                    <asp:TextBox ID="txt_komediBakiye" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>GERİLİM FİLMİ BAKİYESİ:</td>
                <td>
                    <asp:TextBox ID="txt_gerilimBakiye" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>ÇİZGİ FİLİM BAKİYESİ:</td>
                <td>
                    <asp:TextBox ID="txt_cizgiFilmBakiye" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>TOPLAM BAKİYE:</td>
                <td>
                    <asp:TextBox ID="txt_toplamBakiye" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button_bakiye" runat="server" Text="BAKİYE GÖR" OnClick="Button_bakiye_Click"></asp:Button>

                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
