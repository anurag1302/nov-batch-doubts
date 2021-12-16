using System;
using System.Collections.Generic;

namespace App.Models.Person
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public List<PersonAddressModel> Addresses { get; set; }
    }
}
