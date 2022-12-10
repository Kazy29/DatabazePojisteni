using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabazePojisteni;

public class Databaze
{

    public ArrayList<Pojistenec> databaze;

    public Databaze()
    {
        this.databaze = new ArrayList<Pojistenec>();
        Console.WriteLine("Vytváření prázdné databáze");
    }

    public void add(string jmeno, string prijmeni, int vek, long telefon)
    {
        Console.WriteLine("Vytváření nového pojištěnce");
        this.databaze.add(new Pojistenec(jmeno, prijmeni, vek, telefon));
    }

    public void listUsers()
    {
        if (this.databaze.isEmpty())
        {
            Console.WriteLine("Databáze je prázdna");
            return;
        }

        Iterator<Pojistenec> iterator = this.databaze.iterator();
        while (iterator.hasNext())
        {
            Pojistenec pojistenec = iterator.next();
            Console.WriteLine(pojistenec.toString());
        }

    }

    public void findUser(string jmeno, string prijmeni)
    {
        Iterator<Pojistenec> iterator = this.databaze.iterator();
        while (iterator.hasNext())
        {
            Pojistenec pojistenec = iterator.next();
            if ((jmeno.equals(pojistenec.jmeno) && prijmeni.equals(pojistenec.prijmeni)))
            {
                Console.WriteLine(pojistenec.toString());
                return;
            }

        }

        Console.WriteLine("Uživatel neexistuje");
    }
}