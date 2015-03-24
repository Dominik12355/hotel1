using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Log_AdminPanel : System.Web.UI.Page
{
    public void clear()
    {
        tbfname.Text = "";
        tbgroup.Text = "";
        tbpass.Text = "";
        tblogin.Text = "";
        tblname.Text = "";
        tbpass.Visible = false;
        tblogin.Visible = false;
        tblname.Visible = false;
        tbgroup.Visible = false;
        tbfname.Visible = false;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Dodaj_uzytkownika_Click(object sender, EventArgs e)
    {

        tbpass.TextMode = TextBoxMode.Password;
        lblwynik.Visible = false;
        PanelUzyt.Visible = true;
        Label1.Text = "Login:";
        Label2.Text = "Password:";
        Label3.Text = "Grupa:";
        Label4.Text = "Imie:";
        Label5.Text = "Nazwisko:";
        Label3.Visible = true;
        Label4.Visible = true;
        Label5.Visible = true;
        tblogin.Visible = true;
        tbpass.Visible = true;
        tbfname.Visible = true;
        tblname.Visible = true;
        tbgroup.Visible = true;
        Wybor.Text = "1";
        bZatwierdz.Visible = true;
    }
    protected void Zmien_uprwanienia_Click(object sender, EventArgs e)
    {
        clear();
        tbpass.TextMode = TextBoxMode.SingleLine;
        lblwynik.Visible = false;
        PanelUzyt.Visible = true;
        tblogin.Visible = true;
        tbpass.Visible = true;
        Label1.Text = "Login:";
        Label2.Text = "Grupa:";
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Wybor.Text = "2";
        bZatwierdz.Visible = true;
    }
    protected void Dodaj_usługę_Click(object sender, EventArgs e)
    {
        clear();
        tbpass.TextMode = TextBoxMode.SingleLine;
        lblwynik.Visible = false;
        PanelUzyt.Visible = true;
        Label1.Text = "Nazwa: ";
        Label2.Text = "Opis";
        Label3.Text = "Cena:";
        Label3.Visible = true;
        tbgroup.Visible = true;
        tblogin.Visible = true;
        tbpass.Visible = true;
        Label4.Visible = false;
        Label5.Visible = false;
        Wybor.Text = "3";
        bZatwierdz.Visible = true;
    }
    protected void Dodaj_pokoj_Click(object sender, EventArgs e)
    {
        clear();
        tbpass.TextMode = TextBoxMode.SingleLine;
        lblwynik.Visible = false;
        PanelUzyt.Visible = true;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Label1.Visible = true;
        Label1.Text = "Nr pokoju:";
        Label2.Visible = true;
        Label2.Text = "Rodzaj:";
        tblogin.Visible = true;
        tbpass.Visible = true;
        Wybor.Text = "4";
        bZatwierdz.Visible = true;
    }

    protected void bZatwierdz_Click(object sender, EventArgs e)
    {
        Administracja admin = new Administracja();
        bool udane = false;
        if (Wybor.Text == "1" )
        {
            udane = admin.Dodaj_User(tblogin.Text, tbpass.Text, tbfname.Text, tblname.Text, int.Parse(tbgroup.Text));
            if (udane)
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Dodano użytkownika " + tblogin.Text + ".";
            }
            else
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Dodawanie nowego użytkownika nie powiodło się.";
            }
        }
        else if (Wybor.Text == "2")
        {
            udane = admin.Zmien_uprawnienia(tblogin.Text, int.Parse(tbpass.Text));
            if (udane)
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Zmieniono uprawnienia uzytkownikowi " + tblogin.Text + ".";
            }
            else
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Nie udało się zmienić uprawnień urzytkownika " + tblogin.Text + ".";
            }
        }
        else if (Wybor.Text == "3")
        {
            udane = admin.Dodaj_usluge(tblogin.Text, tbpass.Text, int.Parse(tbgroup.Text));
            if (udane)
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Dodano nową usługę.";
            }
            else
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Nie udało się dodać nowej usługi.";
            }

        }
        else if (Wybor.Text == "4")
        {
            udane = admin.Dodaj_pokoj(tblogin.Text, tbpass.Text);
            if (udane)
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Dodano nowy pokój.";
            }
            else
            {
                lblwynik.Visible = true;
                lblwynik.Text = "Nie udało się dodać nowego pokoju.";
            }
        }
    }

}