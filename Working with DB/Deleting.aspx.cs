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

public partial class Deleting : System.Web.UI.Page
{
    public string userMsg;
    protected void Page_Load(object sender, EventArgs e)
    {

       
        string tableName = "personalData";//שם הטבלה
        string selectQuery = "";


        if (Request.Form["del_id"] != null)
        {

            selectQuery = "SELECT * FROM " + tableName;//נבדוק אם מספר תז קיים
            selectQuery += " WHERE ";
            selectQuery += " idNum = '" + Request.Form["idNum"] + "'";
            //בדיקה האם תז קיימת במסד
            if (MyAdoHelper.IsExist(selectQuery))
            {
                //אם קיים נבצע מחיקה
                string idNum = Request.Form["idNum"];
                string sql = "DELETE FROM personalData WHERE idNum = '" + idNum + "'";
                //ביצוע והצגת מספר הרשומות שנמחקו
                userMsg = MyAdoHelper.RowsAffected(sql).ToString() + "  רשומה/רשומות נמחקו ";

                //מחיקת הרשומות בלבד
                //MyAdoHelper.DoQuery(sql);
                //userMsg = " הרשומה נמחקה"; 
            }
            else
                userMsg = "תז לא קיימת";
        }


    }
}


