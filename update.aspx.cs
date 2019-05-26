using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;




public partial class update : System.Web.UI.Page
{
    public string userMsg;
    protected void Page_Load(object sender, EventArgs e)
    {


        string tableName = "people";//שם הטבלה
        string selectQuery = "";
        string sql = "";

        string username = Request.Form["username"];
        string fname = Request.Form["fnameedit"];
        string lname = Request.Form["lnameedit"];
        string age = Request.Form["ageedit"];

            if (Request.Form["update"] != null)
            {
                if (Request.Form["username"] != "admin")
                {
                selectQuery = "SELECT * FROM " + tableName + " WHERE username='" + username + "'";
                sql = "UPDATE  " + tableName + "  SET fname='" + fname + "',lname='" + lname + "', age='" + age +"' WHERE username='" + username + "'";

                if (MyAdoHelper.IsExist(selectQuery))
                {

                    MyAdoHelper.DoQuery(sql);
                    userMsg = "The user has updated!";
                }
                else
                    userMsg = "Wrong username";
            }
                else
                    userMsg = "You can't update an Admin";
        }
       
    }
}



