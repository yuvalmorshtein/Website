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

public partial class Delete : System.Web.UI.Page
{
    public string userMsg;
    protected void Page_Load(object sender, EventArgs e)
    {


        string tableName = "people";//שם הטבלה
        string selectQuery = "";


        if (Request.Form["Delete"] != null)
        {
            if (Request.Form["user"]!="admin")
            { 
            selectQuery = "SELECT * FROM " + tableName;//נבדוק אם מספר תז קיים
            selectQuery += " WHERE ";
            selectQuery += " username = '" + Request.Form["user"] + "'";
            //בדיקה האם תז קיימת במסד
            if (MyAdoHelper.IsExist(selectQuery))
            {
                //אם קיים נבצע מחיקה
                string username = Request.Form["user"];
                string sql = "DELETE FROM people WHERE username = '" + username + "'";
                //ביצוע והצגת מספר הרשומות שנמחקו
                userMsg = MyAdoHelper.RowsAffected(sql).ToString() + "  רשומה/רשומות נמחקו ";

                //מחיקת הרשומות בלבד
                MyAdoHelper.DoQuery(sql);
                userMsg = "The deletion was succesfull";
            }
                else
            userMsg = "The username is not valid";
              }
            else
                userMsg = "You can't delete an Admin";

        }
        



    }
}


