<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insertion.aspx.cs" Inherits="Insertion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="myform"  method="post" action="Insertion.aspx">
     <table>
      <tr><td>תעודת זהות:</td><td><input type="text" id="idNum" name="idNum" /></td></tr>
      <tr><td>שם פרטי:</td><td> <input
           type="text" id="fName" name="fName" /></td></tr> 
      <tr><td>שם משפחה:</td><td> <input type="text" id="lName" name="lName" /></td></tr> 
     <tr><td>מין:</td><td> זכר <input type="radio" name="gender" id="gender1" value="male" /></td>
                        <td> נקבה <input type="radio" name="gender" id="gender2" value="female" /></td>
      </tr> 
      <tr><td>ססמא:</td><td> <input type="text" id="password" name="password" /></td></tr> 

      <tr><td><input type="submit" id="submit" name="submit" value="שלח" /></td><td><input type="reset" value="נקה" /></td></tr> 
    </table>
    </form>
   
</body>

</html>
