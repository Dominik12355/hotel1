using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Lacze
/// </summary>
public class Lacze
{
    static ObslugaDataContext polaczenie = new ObslugaDataContext();
	public Lacze()
	{
	}
    public static ObslugaDataContext Polacz()
    {
        return polaczenie;
    }
}