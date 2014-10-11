<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="BasicFormSample.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="leftInput"></asp:TextBox>
            <asp:Label runat="server">+</asp:Label>
            <asp:TextBox runat="server" ID="rightInput"></asp:TextBox>
            <asp:Button runat="server" Text="Add" OnClick="Button_Click" />
            <asp:Label runat="server" ID="resultOutput"></asp:Label>
        </div>
    </form>
</body>
</html>
