﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    
    public partial class Login : System.Web.UI.Page
    { 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true) return;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }
        DBCVENTITYEntities1 db = new DBCVENTITYEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {

            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == TextBox1.Text && x.SIFRE == TextBox2.Text select x;
            if (sorgu.Any())
            {


                Response.Redirect("İstatistik.aspx");
            }
            else
            {
              
                Response.Write("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}