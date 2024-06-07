using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit.Model;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> ucenici = new List<Ucenik>();
                       
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Unesite podatke za učenika {i + 1}:");

                Console.WriteLine("Unesite ime učenika:");
                string ime = Console.ReadLine();

                Console.WriteLine("Unesite prezime učenika:");
                string prezime = Console.ReadLine();

                Console.WriteLine("Unesite datum rođenja učenika (u formatu dd-mm-yyyy):");
                DateTime datumRodjenja;
                while (!DateTime.TryParse(Console.ReadLine(), out datumRodjenja))
                {
                    Console.WriteLine("Unesite valjani datum rođenja (u formatu dd-mm-yyyy):");
                }

                Console.WriteLine("Unesite prosjek učenika:");
                double prosjek;
                while (!double.TryParse(Console.ReadLine(), out prosjek) || prosjek < 1 || prosjek > 5)
                {
                    Console.WriteLine("Unesite valjani prosjek (od 1 do 5):");
                }

                Ucenik ucenik = new Ucenik(ime, prezime, datumRodjenja, prosjek);
                ucenici.Add(ucenik);
            }

            Console.WriteLine("\nPodaci o učeniku:\n");
            foreach (Ucenik ucenik in ucenici)
            {
                ucenik.IspisiPodatke();
                Console.WriteLine();
            }

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
