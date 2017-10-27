
namespace PencilJoyTests.Data
{
    class CheckoutAddressData
    {
        internal string Username { get; set; }
        internal string Lastname { get; set; }
        internal string Street { get; set; }
        internal string City { get; set; }
        internal string ZipCode { get; set; }
        internal string Phone { get; set; }
        internal int NumberCountry { get; set; }

        public CheckoutAddressData()
        {
            Username = Faker.Name.First();
            Lastname = Faker.Name.Last();
            Street = Faker.Address.StreetAddress();
            City = Faker.Address.City();
            ZipCode = Faker.Address.ZipCode();
            Phone = Faker.Phone.Number();
            NumberCountry = Faker.RandomNumber.Next(0, 22);
        }
        public CheckoutAddressData(string username, string lastname, string street, string city, string zipCode, string phone)
        {
            Username = username;
            Lastname = lastname;
            Street = street;
            City = city;
            ZipCode = zipCode;
            Phone = phone;
        }

       
    }
}
