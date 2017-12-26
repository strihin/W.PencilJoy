
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
        internal  string Region { get; set; }

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
        public CheckoutAddressData(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            this.Username = Username;
            this.Lastname = Lastname;
            this.Street = Street;
            this.City = City;
            this.ZipCode = ZipCode;
            this.Phone = Phone;
            this.NumberCountry = NumberCountry;
            this.Region = Region;
        }

       
    }
}
