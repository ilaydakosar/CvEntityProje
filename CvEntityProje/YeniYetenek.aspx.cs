using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         DBCVENTITYEntities1 DB = new DBCVENTITYEntities1();    
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLYETENEK T = new TBLYETENEK();
            T.YETENEK = TextBox1.Text;
            DB.TBLYETENEK.Add(T);
            DB.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}