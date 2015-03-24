using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPageLogin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string nazwa = Request.QueryString["imie"];
        data.Text = "Hotels " + DateTime.Now.Year.ToString();
        lblLogin.Text = "Witaj " + nazwa + ".";
    }
}
