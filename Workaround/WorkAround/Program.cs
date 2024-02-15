using System;
using System.Collections.Generic;
//using Business.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas = new Vatandas();
            vatandas.FirstName = "Asuman";
            Console.WriteLine(vatandas.FirstName);

            List<string> newCities = new List<string> { "Ankara", "İstanbul", "Bursa" };
            foreach (string c in newCities)
            {
                Console.WriteLine(c);
            }
            Person person = new Person();
            person.FirstName = "ASUMAN";
            person.LastName = "KİPER";
            person.NationalId = 123;
            person.DateOfBirthYear = 2000;

            PttManager manager = new PttManager(new PersonManager());
            manager.GiveMask(person);


            Console.ReadLine();

        }
        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }

    }
    public class Vatandas
    {
        string nationalId = "12345678910";
        string firstName = "Asuman";
        string lastName = "Kiper";
        int birthDate = 2000;
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; }


    }
}
