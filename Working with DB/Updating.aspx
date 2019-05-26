<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Updating.aspx.cs" Inherits="Updating" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body dir="rtl">
    <form id="simpleEdit" action="Updating.aspx" method="post">
   הכנס מספר תעודת זהות:
   <input type='text' name='idEdit' />
    <br />
   הכנס ססמה נוכחית: 
   <input type='password' name='oldpassEdit' />
    <br />
   הכנס ססמה חדשה: 
   <input type='password' name='newpassEdit' />
    <br />
    <input type='submit' name='subEdit' value="עדכן" />
    </form>
    
    <%=userMsg %>
</body>
</html>

