<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Selecting2.aspx.cs" Inherits="Selecting2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
בחר שם מהרשימה להצגת הפרטים
שים לב שכל שם מופיע פעם אחת בלבד - ויתכן שקיימים שמות זהים

<% =userMsg %>

<form action="Selecting2.aspx" method='post' >
   <%=usersList%>
   <input type="reset" id="reset" name="reset" value="נקה" />
   <input type="submit" id="showFname" name="showFname" value="הצג"/>
</form>
</body>
</html>

