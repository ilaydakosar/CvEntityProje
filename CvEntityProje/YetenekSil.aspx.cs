using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities1 DB = new DBCVENTITYEntities1();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk = DB.TBLYETENEK.Find(x);
            DB.TBLYETENEK.Remove(ytnk);
            DB.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}