using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logowanie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void bLoguj_Click(object sender, EventArgs e)
    {
        ObslugaDataContext polaczenie = Lacze.Polacz();
        var u = from us in polaczenie.Users where us.Login.Trim() == tbLogin.Text && us.Password.Trim() == tbPass.Text.GetHashCode().ToString() select us;
        if (u.Count() == 0)
        {
            Response.Redirect("Logowanie.aspx");
        }
        else
        {
            if (u.First().Group_id == 1)
            {
                Session["LogName"] = u.First().FirstName.Trim();
                Response.Redirect("~/Log/IndexLog.aspx?imie="+Session["LogName"]);
            }
            else if (u.First().Group_id == 2)
            {
                Response.Redirect("~/Log/AdminPanel.aspx");
            }
        }
    }
}