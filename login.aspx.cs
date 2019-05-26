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


public partial class login : System.Web.UI.Page
{
    public string RegStatus;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {

            string uName = Request.Form["username"];
            string pWord = Request.Form["password"];
            string selectQuery = "SELECT * FROM people WHERE username = '" + uName + "' AND password = '" + pWord + "';";
            if (MyAdoHelper.IsExist(selectQuery))
            {
                Session["uName"] = uName;
                Session["pWord"] = pWord;
                string check = "Select * From people Where username = '"+ uName + "' and IsAdmin = 'True'";
                if (MyAdoHelper.IsExist(check))
                {
                    Session["IsAdmin"] = "True";
                    Response.Redirect("adminmanage.aspx");
                }
                else
                {
                    Session["IsAdmin"] = "False";
                    Response.Redirect("homepage.aspx");
                }
            }
            else
            {
                RegStatus = "The username or the password is not correct <br/> <a href='login.aspx'>Try again</a>";

            }
        }
    }
}

