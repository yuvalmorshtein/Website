using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class select : System.Web.UI.Page
{
    public string column1 , column2;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public static string setTable(string x, string y)
    {
        string selectQuery = "SELECT * FROM people WHERE " + x + " LIKE '" + y+"%';";
        DataTable table = MyAdoHelper.ExecuteDataTable(selectQuery);
        int length = table.Rows.Count; // מספר הרשומות בטבלה
        if (length > 0)// אם נמצאו רשומות
        {
            string usersList = "";
            usersList += "<table style='border:3px double red'; width:'80%'>"; // פתיחת טבלה והכנת כותרת לנתונים המוצגים
            usersList += "<tr>";
            usersList += "<td style='border:1px solid blue; font-size:medium'>Username</th>";
            usersList += "<td style='border:1px solid blue ; font-size:medium' ;>First name</th>";
            usersList += "<td style='border:1px solid blue; font-size:medium' ;>Last name</th>";
            usersList += "<td style='border:1px solid blue; font-size:medium' ;>E-mail</th>";
            usersList += "<td style='border:1px solid blue; font-size:medium' ;>Phone number</th>";
            usersList += "<td style='border:1px solid blue; font-size:medium' ;>Age</th>";
            usersList += "<td style='border:1px solid blue;font-size:medium' ;>Gender</th>";
            usersList += "<td style='border:1px solid blue;font-size:medium' ;>Marital status</th>";
            usersList += "<td style='border:1px solid blue;font-size:medium' ;>Password</th>";
            usersList += "<td style='border:1px solid blue;font-size:medium' ;>Requests</th>";
            usersList += "<td style='border:1px solid blue;font-size:medium' ;>Admin</th>";
            usersList += "<td style='border:1px solid blue;font-size:medium' ;>Delete</th>";
            usersList += "<td style='border:1px solid blue;font-size:medium' ;>Update</th>";
            usersList += "</tr>";
            for (int i = 0; i < length; i++) // הדפסת הרשומות
            { // הדפסת כל הרשומות בטבלה

                usersList += "<tr>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;>" + table.Rows[i]["username"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;>" + table.Rows[i]["fName"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;>" + table.Rows[i]["lName"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["mail"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["pnum"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["age"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["gender"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["mstatus"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["password"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["special"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;> " + table.Rows[i]["IsAdmin"] + "</td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;><a href='Delete.aspx?username=" + table.Rows[i]["username"] + "'>Delete</a></td>";
                usersList += "<td style='border:1px solid red; font-size:x-small' ;><a href='Update.aspx?username=" + table.Rows[i]["username"] + "&oldpassEdit = " + table.Rows[i]["password"] + "'>Update</a></td>";
                usersList += "</tr>";




            }
            usersList += "</table>";// סגירת טבלה
            string usersCount = length.ToString();
            return usersList;


        }
        else
            return "There aren't members";
    }
}
