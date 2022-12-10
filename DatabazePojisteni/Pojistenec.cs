using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabazePojisteni;

public class Pojistenec
{

    public string jmeno;

    public string prijmeni;

    public int vek;

    public long telefon;

    public Pojistenec(string jmeno, string prijmeni, int vek, long telefon)
    {
        this.jmeno = this.jmeno;
        this.prijmeni = this.prijmeni;
        this.vek = this.vek;
        this.telefon = this.telefon;
    }

    [Override()]
    public string toString()
    {
        return new string(("Pojistenec: "
                        + (this.jmeno + (" | "
                        + (this.prijmeni + (" | "
                        + (this.vek + (" | " + this.telefon))))))));
    }
}