<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogsView.aspx.cs" Inherits="Logging.Client.Web.WebForms.LogsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="refresh" content="5">
    <style>
        .log-info {
            background-color: DarkTurquoise;
        }

        .log-warning {
            background-color: DarkOrange;
        }

        .log-error {
            background-color: Tomato;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView runat="server" ID="grid"></asp:GridView>
    </div>
    </form>
</body>
</html>
