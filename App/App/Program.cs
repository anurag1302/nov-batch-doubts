using App.DataRepository;
using System;

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

            Console.ReadLine();
        }
    }
}
