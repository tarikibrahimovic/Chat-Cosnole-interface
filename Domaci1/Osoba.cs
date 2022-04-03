using System;
using System.Collections.Generic;

namespace Domaci1
{
    public class Osoba
    {
        private string tip;

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private int plata;

        public int Plata
        {
            get { return plata; }
            set { plata = value; }
        }



        public Osoba(string tip,int id,string ime,string prezime,int plata)
        {
            this.tip = tip; 
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.plata = plata;
        }

        public void Ispis()
        {
            Console.WriteLine($"Ime: {ime}, prezime: {prezime}, plata: {plata}, \n id: {id}, tip: {tip}");
        }
        
        public void Zamena(string ime,string prezime,int plata)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.plata = plata;
        }

        public void TestPoruka(Osoba o, string poruka, List<Osoba> osobe)
        {
            List<Osoba> pomocnaDev = new List<Osoba>();
            List<Osoba> pomocnaQa = new List<Osoba>();
            //pomocnaDev = (List<Osoba>)osobe.Where(os => os.Tip == "Developer");
            foreach(Osoba osoba in osobe)
            {
                if(osoba.Tip == "Developer")
                {
                    pomocnaDev.Add(osoba);
                }
                else
                {
                    pomocnaQa.Add(osoba);
                }
            }
            //pomocnaQa = (List<Osoba>)osobe.Where(os => os.Tip == "QA");
            if (poruka.StartsWith("feature/"))
            {
                foreach (Osoba osoba in pomocnaDev)
                {
                    if(o.Id == osoba.Id)
                    {
                        continue;
                    }
                    else {
                        Console.WriteLine($"{osoba.Ime} {osoba.Prezime} {osoba.Tip} : {o.Ime} {o.Prezime} \n poruka: {poruka}");
                    }
                }
            }
            else if (poruka.StartsWith("testing/"))
            {
                foreach (Osoba osoba in pomocnaQa)
                {
                    if (o.Id == osoba.Id)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{osoba.Ime} {osoba.Prezime} {osoba.Tip} : {o.Ime} {o.Prezime} \n poruka: {poruka}");
                    }
                }
            }
            else
            {
                foreach (Osoba osoba in osobe)
                {
                    if (o.Id == osoba.Id)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{osoba.Ime} {osoba.Prezime} {osoba.Tip} : {o.Ime} {o.Prezime} \n poruka: {poruka}");
                    }
                }
            }
        }
    }
}
