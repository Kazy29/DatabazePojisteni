using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabazePojisteni;

using System.Scanner;

public class Databazepojisteni
{

    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        Databaze databaze = new Databaze();
        int volba = 0;
        while ((volba != 4))
        {
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
            volba = Integer.parseInt(sc.nextLine());
            switch (volba)
            {
                case 1:
                    Console.WriteLine("Zadejte jméno pojištěného");
                    string jmeno = sc.nextLine();
                    Console.WriteLine("Zadejte příjmení pojištěného");
                    string prijmeni = sc.nextLine();
                    Console.WriteLine("Zadejte telefon pojištěného");
                    Long telefon = Long.parseLong(sc.nextLine());
                    Console.WriteLine("Zadejte věk pojištěného");
                    int vek = Integer.parseInt(sc.nextLine());
                    databaze.add(jmeno, prijmeni, vek, telefon);
                    break;
                    break;
                case 2:
                    databaze.listUsers();
                    break;
                case 3:
                    Console.WriteLine("Zadejte jméno pojištěného");
                    string jmeno = sc.nextLine();
                    Console.WriteLine("Zadejte příjmení pojištěného");
                    string prijmeni = sc.nextLine();
                    databaze.findUser(jmeno, prijmeni);
                    break;
                    break;
            }
        }

        Console.WriteLine("Konec programu");
    }
}
