﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderSystem
{
    public partial class logOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            signOut();
        }

        private void signOut()
        {

            FormsAuthentication.SignOut();

            // clear authentication cookie
            HttpCookie cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, "");
            cookie1.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie1);

            //// clear session cookie (not necessary for your current problem but i would recommend you do it anyway)
            HttpCookie cookie2 = new HttpCookie("ASP.NET_SessionId", "");
            cookie2.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie2);

            FormsAuthentication.RedirectToLoginPage();

            //scriptmsg += "window.open('SignOut.aspx','main');";
            //Response.Redirect("Default.aspx");

        }
    }
}