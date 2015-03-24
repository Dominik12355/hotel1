using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Administracja
/// </summary>
public class Administracja
{
	public Administracja()
	{
	}
    public bool Dodaj_usluge(string na,string o, int c)
    {
        ObslugaDataContext polaczenie =  Lacze.Polacz();
        var u = from us in polaczenie.Uslugis where us.Nazwa.Trim() == na select us;
        if (u.Count() == 0)
        {
            Uslugi nowa_usluga = new Uslugi();
            polaczenie.Uslugis.InsertOnSubmit(nowa_usluga);
            nowa_usluga.Nazwa = na;
            nowa_usluga.Opis = o;
            nowa_usluga.Cena = c;
            polaczenie.SubmitChanges();
            return true;
        }
        else
            return false;
    }
    public bool Dodaj_User(string log,string pass,string i,string n,int g)
    {
        ObslugaDataContext polaczenie = Lacze.Polacz();
        var u = from us in polaczenie.Users where us.Login.Trim() == log select us;
        if (u.Count() == 0)
        {
            User nowy_user = new User();
            polaczenie.Users.InsertOnSubmit(nowy_user);
            nowy_user.Group_id = g;
            nowy_user.Login = log;
            nowy_user.Password = pass.GetHashCode().ToString();
            nowy_user.FirstName = i;
            nowy_user.LastName = n;
            polaczenie.SubmitChanges();
            return true;
        }
        else 
            return false;
    }
    public bool Zmien_uprawnienia (string log,int g)
    {
        ObslugaDataContext polaczenie = Lacze.Polacz();
        var u = from us in polaczenie.Users where us.Login.Trim() == log select us;
        if (u.Count() == 1)
        {
            u.First().Group_id = g;
            polaczenie.SubmitChanges();
            return true;
        }
        return false;
    }
    public bool Dodaj_pokoj (string nr, string r)
    {
        ObslugaDataContext polaczenie = Lacze.Polacz();
        var u = from us in polaczenie.Pokojes where us.Nr_pokoju.Trim() == nr select us;
        if (u.Count() == 0)
        {
            Pokoje nowy_pokoj = new Pokoje();
            polaczenie.Pokojes.InsertOnSubmit(nowy_pokoj);
            nowy_pokoj.Nr_pokoju = nr;
            nowy_pokoj.Rodzaj = r;
            polaczenie.SubmitChanges();
            return true;
        }
        else
            return false;
    }
    
}