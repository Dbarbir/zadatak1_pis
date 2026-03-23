using System;

namespace zadatak1_pis
{
    public class Klasa
    {
        public string poruka = "Ovo je klasa";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Klasa k = new Klasa();
            Console.WriteLine(k.poruka);
            int a = 6;
        }
    }
}