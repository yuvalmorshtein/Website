using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Insertion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            // השמת ערך השדות שנשלחו במשתנים
            string username = Request.Form["username"];
            string fname = Request.Form["fname"];
            string lname = Request.Form["lname"];
            string state = Request.Form["state"];
            string mail = Request.Form["mail"];
            string pnum = Request.Form["pnum"];
            string age = Request.Form["age"];
            string gender = Request.Form["gender"];
            string mstatus = Request.Form["mstatus"];
            string password = Request.Form["password"];
            string special = Request.Form["special"];
            


            
            //משתנה לאחסון הודעה לגבי תקינות ההרשמה
            string RegStatus;
            //עבור שליחת טופס ריק תשלח מחרוזת ריקה - עבור כניסה ישירה לדף זה - ערך השדות אינו מוגדר 
            if ((username == null)||(fname == null) || (lname == null) || (state == null) || (mail == null) || (pnum == null) || (age == null) || (gender == null) || (mstatus == null) || (password == null) || (special == null))
            {
                RegStatus = ("invalid access");
            }
            // עבור שדות המכילים ערכים
            else
            {
                
               
                //מחרוזת לאחזור רשומות לפי ת"ז
                string selectQuery = "SELECT * FROM " + "people";//נבדוק אם מספר תז קיים
                selectQuery += " WHERE ";
                selectQuery += " idNum = '" + Request.Form["username"] + "'";
               
                //בדיקה האם תז קיימת במסד
                if (MyAdoHelper.IsExist(selectQuery))
                {
                    RegStatus = ("This Username already exists");
                }

                else
                {
                    string insertQuery = "INSERT INTO people (username, fname, lname, state, mail, pnum, genser, mstatus, password, special) VALUES ('";// הכנת מחרוזת להכנסת הנתונים
                    insertQuery += username +"', '" + fname + "', '" + lname + "', '" + state + "', '" + mail + "', '" + pnum + "', '" + age + "', '" + gender + "', '" + mstatus + "', '" + password + "', '" + special +"')";
                    MyAdoHelper.DoQuery(insertQuery);
                    RegStatus = ("Succesfull registration");
                }
               
               
            }
            Response.Write(RegStatus);
            Response.End();
        }
    }
}


