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

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    public string Mycount;
    protected void Page_Load(object sender, EventArgs e)
    {
        string tablename = "people";
        string selectquery = "SELECT * FROM " + tablename;

        DataTable table = MyAdoHelper.ExecuteDataTable(selectquery);
        int length = table.Rows.Count;
        Mycount = length.ToString();

    }
}
