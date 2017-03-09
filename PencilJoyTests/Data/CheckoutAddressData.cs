
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
