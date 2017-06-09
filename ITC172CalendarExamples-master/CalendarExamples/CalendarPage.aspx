<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarPage.aspx.cs" Inherits="CalendarPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Calendar</title>
    <link href="CalendarExample.css" rel="stylesheet" />
</head>
<body>
<h1>My Schedule</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar> 
        <p><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
       
    </div>
   
    </form>
</body>
</html>
