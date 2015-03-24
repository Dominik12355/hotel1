using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rejestracja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bRejestruj_Click(object sender, EventArgs e)
    {
        ObslugaDataContext polaczenie = new ObslugaDataContext();
        User nowy = new User();
        var u = from us in polaczenie.Users where us.Login.Trim() == tbLogin.Text select us;
        if (u.Count() == 0)
        {
            if (tbLogin.Text != "" && tbPass.Text != "" && tbImie.Text != "" && TbNazwisko.Text != "")
            {
                polaczenie.Users.InsertOnSubmit(nowy);
                nowy.Login = tbLogin.Text;
                nowy.Password = tbPass.Text.GetHashCode().ToString();
                nowy.Group_id = 1;
                nowy.FirstName = tbImie.Text;
                nowy.LastName = TbNazwisko.Text;
                polaczenie.SubmitChanges();
                Response.Redirect("Logowanie.aspx");
            }
            else if (tbLogin.Text=="" || tbPass.Text==""|| tbImie.Text=="" || TbNazwisko.Text=="")
            {
                lblBlad.Visible = true;
                lblBlad.Text = "Wypełnij wszystkie pola.";
            }

        }
        else
        {
            lblBlad.Visible = true;
            lblBlad.Text = "Taki użytkownik już istnieje! Podaj inny Login.";
        }
    }
}