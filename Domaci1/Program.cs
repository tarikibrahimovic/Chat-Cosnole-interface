using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            List<Osoba> osobe = new List<Osoba>();
            while (true)
            {
                Console.WriteLine("1-Unos, izmena i brisanje podataka");
                Console.WriteLine("2-Slanje poruka");
                int izbor = int.Parse(Console.ReadLine());
                if (izbor == 1)
                {
                    Console.WriteLine("1-Unos novog Developera");
                    Console.WriteLine("2-Izmena developera");
                    Console.WriteLine("3-Brisanje developera");
                    Console.WriteLine("4-Unos novog QA");
                    Console.WriteLine("5-Izmena QA");
                    Console.WriteLine("6-Brisanje QA");
                    Console.WriteLine("0-nazad");
                    izbor = int.Parse(Console.ReadLine());
                    if (izbor == 1)
                    {
                        Console.WriteLine("Unesite Ime:");
                        string ime = Console.ReadLine();
                        Console.WriteLine("Unesite Prezime:");
                        string prezime = Console.ReadLine();
                        Console.WriteLine("Unesite Platu:");
                        int plata = int.Parse(Console.ReadLine());
                        Osoba osoba = new Osoba("Developer", id, ime, prezime, plata);
                        osobe.Add(osoba);
                        osoba.Ispis();
                        id++;
                    }
                    else if (izbor == 2 || izbor == 5)
                    {
                        Console.WriteLine("Unesite id: ");
                        int pom = int.Parse(Console.ReadLine());
                        if (osobe.Count(o => o.Id == pom) == 0)
                        {
                            Console.WriteLine("Ne postoji taj radnik sa tim indexom");
                        }
                        else
                        {
                            Console.WriteLine("Unesite novo ime:");
                            string ime = Console.ReadLine();
                            Console.WriteLine("Unesite novo prezime: ");
                            string prezime = Console.ReadLine();
                            Console.WriteLine("Unesite novu platu: ");
                            int plata = int.Parse(Console.ReadLine());
                            Osoba pomOsoba = osobe.Find(o => o.Id == pom);
                            int index = osobe.IndexOf(pomOsoba);
                            osobe[index].Zamena(ime,prezime,plata);
                        }
                    }
                    else if (izbor == 3) {
                        Console.WriteLine("Unesite id: ");
                        int pom = int.Parse(Console.ReadLine());
                        if (osobe.Count(o => o.Id == pom) == 0)
                        {
                            Console.WriteLine("Ne postoji taj radnik sa tim indexom");
                        }
                        else
                        {
                            Osoba pomOsoba = osobe.Find(o => o.Id == pom);
                            osobe.Remove(pomOsoba);
                        }
                    }
                    else if (izbor == 4)
                    {
                        Console.WriteLine("Unesite Ime:");
                        string ime = Console.ReadLine();
                        Console.WriteLine("Unesite Prezime:");
                        string prezime = Console.ReadLine();
                        Console.WriteLine("Unesite Platu:");
                        int plata = int.Parse(Console.ReadLine());
                        Osoba osoba = new Osoba("QA", id, ime, prezime, plata);
                        id++;
                        osoba.Ispis();
                        osobe.Add(osoba);
                    }
                    else if(izbor == 6) {
                        Console.WriteLine("Unesite id: ");
                        int pom = int.Parse(Console.ReadLine());
                        if (osobe.Count(o => o.Id == pom) == 0)
                        {
                            Console.WriteLine("Ne postoji taj radnik sa tim indexom");
                        }
                        else
                        {
                            Osoba pomOsoba = osobe.Find(o => o.Id == pom);
                            osobe.Remove(pomOsoba);
                        }
                    }
                    else if(izbor == 7)
                    {
                        foreach(Osoba osoba in osobe)
                        {
                            osoba.Ispis();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (izbor == 2)
                {
                    Console.WriteLine("Unesite index developera: ");
                    int index = int.Parse(Console.ReadLine());
                    if (osobe.Count(o => o.Id == index) == 0)
                    {
                        Console.WriteLine("Takav radnik ne postoji!");
                    }
                    else
                    {
                        Osoba pomOsoba = osobe.Find(o => o.Id == index);
                        int t = osobe.IndexOf(pomOsoba);
                        //osobe[t]
                        Console.WriteLine("Unesite zeljenu poruku: ");
                        string poruka = Console.ReadLine();
                        osobe[t].TestPoruka(osobe[t],poruka,osobe);
                    }
                }
                else
                {
                    Console.WriteLine("Unesite ponovo: ");
                }
            }
        }
    }
}
