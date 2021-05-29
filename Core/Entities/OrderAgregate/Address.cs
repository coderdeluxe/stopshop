namespace Core.Entities.OrderAgregate
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string street, string barangay, string city, string province)
        {
            Street = street;
            Barangay = barangay;
            City = city;
            Province = province;
        }

        public string Street { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
    }
}