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

public partial class Updating : System.Web.UI.Page
{
    public string userMsg;
    protected void Page_Load(object sender, EventArgs e)
    {

      
        string tableName = "personalData";//שם הטבלה
        string selectQuery = "";
        string sql = "";

        string idNum = Request.Form["idEdit"];
        string pass = Request.Form["oldpassEdit"];
        string repass = Request.Form["newpassEdit"];

        if (Request.Form["subEdit"] != null)
        {
            selectQuery = "SELECT * FROM " + tableName + " WHERE idNum='" + idNum + "' AND passwd='" + pass + "'";
            sql = "UPDATE  " + tableName + "  SET passwd='" + repass + "' WHERE idNum='" + idNum + "' AND passwd='" + pass + "'";

            if (MyAdoHelper.IsExist(selectQuery))
            {

                MyAdoHelper.DoQuery(sql);
                userMsg = "הפרטים עודכנו";
            }
            else
                userMsg = "מספר תז לא תקין או הססמה שגויה";
        }
    }
}



