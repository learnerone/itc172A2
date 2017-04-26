<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <h1>My Event Calendar</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged" BackColor="#FFCC66"></asp:Calendar>
        <asp:Label ID="Label" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
