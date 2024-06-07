using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public double Prosjek { get; set; }

        public Ucenik(string ime, string prezime, DateTime datumRodjenja, double prosjek)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Prosjek = prosjek;
        }

        public int Starost()
        {
            DateTime danasnjiDatum = DateTime.Now;
            int godineUcenika = danasnjiDatum.Year - DatumRodjenja.Year;
            if (danasnjiDatum < DatumRodjenja.AddYears(godineUcenika))
            {
                godineUcenika--;
            }
            return godineUcenika;
        }

        public string UkupanProsjek()
        {
            if (Prosjek >= 1 && Prosjek <= 1.49)
            {
                return "Nedovoljan!";
            }
            else if (Prosjek >= 1.50 && Prosjek <= 2.49)
            {
                return "Dovoljan!";
            }
            else if (Prosjek >= 2.50 && Prosjek <= 3.49)
            {
                return "Dobar!";
            }
            else if (Prosjek >= 3.50 && Prosjek <= 4.49)
            {
                return "Vrlo dobar!";
            }
            else if (Prosjek >= 4.50 && Prosjek <= 5.00)
            {
                return "Odličan!";
            }
            else
            {
                return null;
            }
        }

        public void IspisiPodatke()
        {           
            Console.WriteLine($"Ime: {Ime}");
            Console.WriteLine($"Prezime: {Prezime}");
            Console.WriteLine($"Datum Rođenja: {DatumRodjenja.ToString("dd-mm-yyyy")}");
            Console.WriteLine($"Starost: {Starost()} godina");
            Console.WriteLine($"Prosjek: {Prosjek} - {UkupanProsjek()}");
            Console.WriteLine("--------------------------------------");
        }
    }
}
