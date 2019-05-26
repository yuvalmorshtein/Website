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

public partial class Selecting2 : System.Web.UI.Page
{
    public string userMsg = "";
    public string usersList = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string selectQuery = "SELECT fName  FROM personalData GROUP BY fName";
        //string selectQuery = "SELECT * FROM " + tableName.ToString() + " ORDER BY idNum"; //   שאילתת בחירה ממויינת לפי תז 
        //string selectQuery = "SELECT * FROM " + tableName; // שאילתת בחירה

        DataTable table = MyAdoHelper.ExecuteDataTable(selectQuery);
        int length = table.Rows.Count; // מספר הרשומות בטבלה
        if (length > 0)// אם נמצאו רשומות
        {
            usersList += "<select id='fName' name='fName'>";// יצירת רשימה נגללת
            for (int i = 0; i < length; i++) // הדפסת הרשומות
            { // הדפסת כל הרשומות בטבלה
                usersList += "<option >";
                usersList += table.Rows[i]["fName"].ToString();
                usersList += "</option>";
            }

            usersList += "</select>";

        }


        if (Request.Form["showFname"] != null)
        {

            string fName = Request.Form["fName"];
            string sql = "SELECT * FROM personalData WHERE fName = '" + fName + "'";
            userMsg = MyAdoHelper.printDataTable(sql).ToString();


        }



    }
}





