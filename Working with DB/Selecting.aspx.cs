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

public partial class Selecting : System.Web.UI.Page
{

    public string usersList;
    public string usersCount;
    protected void Page_Load(object sender, EventArgs e)
    {
        string tableName = "personalData";//שם הטבלה

        string selectQuery = "SELECT * FROM " + tableName; // שאילתת בחירה

        DataTable table = MyAdoHelper.ExecuteDataTable(selectQuery);
        int length = table.Rows.Count; // מספר הרשומות בטבלה
        if (length > 0)// אם נמצאו רשומות
        {
            usersList += "<table style='border:3px double red' ;>"; // פתיחת טבלה והכנת כותרת לנתונים המוצגים
            usersList += "<tr >";
            usersList += "<th style='border:1px solid blue' ;>תעודת זהות</th>";
            usersList += "<th style='border:1px solid blue' ;>שם פרטי</th>";
            usersList += "<th style='border:1px solid blue' ;>שם משפחה</th>";
            usersList += "<th style='border:1px solid blue' ;>ססמה</th>";
            usersList += "</tr>";
            for (int i = 0; i < length; i++) // הדפסת הרשומות
            { // הדפסת כל הרשומות בטבלה
                usersList += "<tr>";
                usersList += "<td style='border:1px solid red' ;>" + table.Rows[i]["idNum"] + "</td>";
                usersList += "<td style='border:1px solid red' ;>" + table.Rows[i]["fName"] + "</td>";
                usersList += "<td style='border:1px solid red' ;>" + table.Rows[i]["lName"] + "</td>";
                usersList += "<td style='border:1px solid red' ;> " + table.Rows[i]["passwd"] + "</td>";
                usersList += "</tr>";
            }
            usersList += "</table>";// סגירת טבלה
            usersCount = length.ToString();

        }
    }
}

