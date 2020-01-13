using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginsWebconfig
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            //validar o utilizador

            //iniciar sessão
            Session["email"] = "joaquim@gmail.com";
            FormsAuthentication.SetAuthCookie("joaquim", false);
            if (Request["ReturnUrl"] != null)
            {
                string url = Server.UrlDecode(Request["ReturnUrl"]);
                Response.Redirect(url);
            }
            Response.Redirect("~/segura/segura.aspx");
        }
    }
}