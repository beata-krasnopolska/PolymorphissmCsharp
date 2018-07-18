using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //STATYCZNY przeciążenie metod
            //    WyswietlanieDanych wd = new WyswietlanieDanych();
            //    wd.Wyswietl(4);
            //    wd.Wyswietl(4.5);
            //    wd.Wyswietl("4.5");
            //    Console.ReadKey();
            //}
            //class WyswietlanieDanych
            //{
            //    public void Wyswietl(int i)
            //    {
            //        Console.WriteLine("Wynik to: {0}", i);
            //    }
            //    public void Wyswietl(double i)
            //    {
            //        Console.WriteLine("Wynik to: {0}", i);
            //    }
            //    public void Wyswietl(string i)
            //    {
            //        Console.WriteLine("Wynik to: {0}", i);
            //    }
            //}


            //STATYCZNY przeciażenie operatorów
            //coś tu nie działa i nie wiem o co chodzi :(
            double objetosc = 0;
            Pudelko p1 = new Pudelko();
            Pudelko p2 = new Pudelko();
            Pudelko p3 = new Pudelko();

            p1.PobierzDlugosc(3.5);
            p1.PobierzSzerokosc(4);
            p1.PobierzWysokosc(5.5);

            p2.PobierzDlugosc(2.5);
            p2.PobierzSzerokosc(5.0);
            p2.PobierzWysokosc(4.5);

            p3.PobierzDlugosc(12.5);
            p3.PobierzSzerokosc(15);
            p3.PobierzWysokosc(14.5);

            objetosc = p1.ObliczObjetosc();
            Console.WriteLine("Objętość 1 wynosi: {0}", objetosc);

            objetosc = p2.ObliczObjetosc();
            Console.WriteLine("Objętość 2 wynosi: {0}", objetosc);

            p3 = p2 + p1;

            objetosc = p3.ObliczObjetosc();
            Console.WriteLine("Objętość 3 wynosi: {0}", objetosc);
            Console.ReadKey();
        }
    }
    class Pudelko
    {
        private double dlugosc;
        private double szerokosc;
        private double wysokosc;
        public void PobierzDlugosc(double d)
        {
            dlugosc = d;
        }
        public void PobierzSzerokosc(double s)
        {
            szerokosc = s;
        }
        public void PobierzWysokosc(double w)
        {
            wysokosc = w;
        }
        public double ObliczObjetosc()
        {
            return (dlugosc * wysokosc * szerokosc);
        }
        public static Pudelko operator +(Pudelko a, Pudelko b)
        {
            Pudelko pud = new Pudelko();
            pud.wysokosc = a.wysokosc + b.wysokosc;
            pud.szerokosc = a.szerokosc + b.szerokosc;
            pud.dlugosc = a.dlugosc + b.dlugosc;
            return pud;
        }
    }
    
}
