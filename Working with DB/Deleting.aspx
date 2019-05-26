<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deleting.aspx.cs" Inherits="Deleting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>מחיקה לפי תעודת זהות</title>
</head>
<body>
    <h1>מחיקה לפי תעודת זהות</h1>
   <form action="Deleting.aspx" method="post">
  מספר תז למחיקת רשומה: <input type="text" id="idNum" name="idNum" />
    <input type="submit" id="del_id" name="del_id" value="מחק" />
   </form>
    <br />
  <%=userMsg%>
</body>
</html>
