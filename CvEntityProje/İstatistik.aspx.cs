﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class İstatistik : System.Web.UI.Page
    { DBCVENTITYEntities1 db = new DBCVENTITYEntities1() ;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text= db.TBLYETENEK.Count().ToString();
            Label2.Text= db.TBLILETISIM.Count().ToString();
            Label3.Text= db.TBLYETENEK.Average(x => x.DERECE).ToString();
            Label4.Text = db.TBLYETENEK.Max(x => x.DERECE).ToString();
      
           
        }
    }
}