using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Osoba
/// </summary>
public class Osoba
{
    public string osobaLogin;
    public string osobaimie;
    public string osobanazwisko;
    public int suma;
	public Osoba()
	{
	}
    public Osoba (string ol,string oi,string on)
    {
        this.osobaLogin = ol;
        this.osobaimie = oi;
        this.osobanazwisko = on;
        this.suma = 0;
    }
}