using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginsWebconfig.Segura
{
    public partial class segura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_Click(object sender, EventArgs e)
        {
            //terminar sessão
            FormsAuthentication.SignOut();
            Session.Clear();
            Response.Redirect("~/login.aspx");
        }
    }
}