﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="logout.aspx.cs" Inherits="logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><%
             Session.Abandon();
             Response.Redirect("homepage.aspx"); %>
    
    </div>
    </form>
</body>
</html>
