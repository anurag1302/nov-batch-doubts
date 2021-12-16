using App.DataRepository;
using App.Models.Person;
using App.Utilities;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accessing Person Records!");

            var model = Repository.GetPersons();

            foreach(var item in model)
            {
                var personData = $"{"Person's name is: "}{item.FirstName}{" "}" +
                    $"{item.LastName}{" , his/her date of birth is: "}{item.DOB.Value.ToShortDateString()}";
                Console.WriteLine(personData);
                Console.WriteLine("His/Her Addresses are as follows: ");

                foreach(var address in item.Addresses)
                {
                    var addressData = $"{address.Type}{"-"}{address.StreetName}{"-"}{address.Locality}{"-"}{address.City}";
                    Console.WriteLine(addressData);
                }

                Console.WriteLine("********************************************************");
                Console.WriteLine("********************************************************");
            }

            Console.WriteLine("***************INTEREST CALCULATION************************");

            var si = new SimpleInterest();
            var simpleInterest = si.CalculateInterest(12500, 10.5, 10);

            Console.WriteLine(simpleInterest);

            var ci = new CompoundInterest();
            var compoundInterest = ci.CalculateInterest(12500, 10.5, 10);

            Console.WriteLine(compoundInterest);

            Console.WriteLine("***************GENERICS WITH CONSTRAINTS************************");

            GenericsUsage<PersonModel> gu = new GenericsUsage<PersonModel>(3,4)
            {
                Records = Repository.GetPersons()
            };

            foreach (var item in gu.Records)
            {
                var personData = $"{"Person's name is: "}{item.FirstName}{" "}" +
                    $"{item.LastName}{" , his/her date of birth is: "}{item.DOB.Value.ToShortDateString()}";
                Console.WriteLine(personData);
                Console.WriteLine("His/Her Addresses are as follows: ");

                foreach (var address in item.Addresses)
                {
                    var addressData = $"{address.Type}{"-"}{address.StreetName}{"-"}{address.Locality}{"-"}{address.City}";
                    Console.WriteLine(addressData);
                }

                Console.WriteLine("********************************************************");
                Console.WriteLine("********************************************************");
            }

            Console.WriteLine("***************GENERICS************************");
            GenericsUsageAlt<PersonModel> guAlt = new GenericsUsageAlt<PersonModel>
            {
                Records = Repository.GetPersons()
            };

            GenericsUsageAlt<int> guAltInt = new GenericsUsageAlt<int>
            {
                Records = new List<int> { 1, 2, 3, 4 }
            };

            foreach(var item in guAltInt.Records)
            {
                Console.WriteLine($"{item} {"\n"}");
            }

            Console.ReadLine();
        }
    }
}
