using App.Models.Person;
using System;
using System.Collections.Generic;

namespace App.DataRepository
{
    public class Repository
    {
        public static List<PersonModel> GetPersons()
        {
            //var list = new List<PersonModel>();
            //var item1 = new PersonModel
            //{
            //    Id=233,
            //    FirstName="test",
            //    LastName="test new",
            //    DOB=DateTime.Today,
            //    Addresses=GetAddresses()

            //};

            //list.Add(item1);
            return new List<PersonModel>
            {
                new PersonModel
                {
                    Id=101,
                    FirstName="John",
                    LastName="Cena",
                    DOB=DateTime.Now,
                    Addresses=new List<PersonAddressModel>
                    {
                        new PersonAddressModel
                        {
                            Type=AddressType.Permanent,
                            StreetName="Street 1",
                            Locality="My Locality",
                            City="New Delhi",
                            State="Delhi",
                            PinCode=110045
                        },
                        new PersonAddressModel
                        {
                            Type=AddressType.Present,
                            StreetName="Street 2",
                            Locality="My Locality 2",
                            City="Gurgaon",
                            State="HR",
                            PinCode=122007
                        }
                    }
                },

                new PersonModel
                {
                    Id=102,
                    FirstName="Dave",
                    LastName="Batista",
                    DOB=DateTime.Now,
                    Addresses=new List<PersonAddressModel>
                    {
                        new PersonAddressModel
                        {
                            Type=AddressType.Permanent,
                            StreetName="Street XYZ",
                            Locality="Batista Locality",
                            City="Chicago",
                            State="Texas",
                            PinCode=null
                        },
                        new PersonAddressModel
                        {
                            Type=AddressType.Present,
                            StreetName="Street ABC",
                            Locality="Batista Locality 2",
                            City="DC",
                            State="Washington",
                            PinCode=123456
                        }
                    }
                },
                new PersonModel
                {
                    Id=103,
                    FirstName="Mary",
                    LastName="Jane",
                    DOB=DateTime.Now,
                    Addresses=new List<PersonAddressModel>
                    {
                        new PersonAddressModel
                        {
                            Type=AddressType.Permanent,
                            StreetName="Street Jane",
                            Locality="Jane Locality",
                            City="Chicago",
                            State="IL",
                            PinCode=90876
                        },
                        new PersonAddressModel
                        {
                            Type=AddressType.Present,
                            StreetName="Street Mary",
                            Locality="Mary Locality 2",
                            City="DC",
                            State="Washington",
                            PinCode=654346
                        }
                    }
                },

            };
        }

        public static List<PersonAddressModel> GetAddresses()
        {
            return new List<PersonAddressModel>
            {
                new PersonAddressModel
                { 
                },
                new PersonAddressModel
                {

                }
            };
        }
    }
}
