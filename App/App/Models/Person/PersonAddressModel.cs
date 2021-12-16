namespace App.Models.Person
{
    public class PersonAddressModel
    {
        public AddressType Type { get; set; }
        public string StreetName { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? PinCode { get; set; }
    }

    public enum AddressType
    {
        Present,
        Permanent
    }
}
