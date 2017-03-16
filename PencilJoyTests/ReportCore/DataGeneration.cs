using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PencilJoyTests.Data;


namespace PencilJoyTests.ReportCore
{
    class DataGeneration
    {
        public CreateBookData createBookData { get; set; }
        public MessageData messageData { get; set; }
        public CheckoutAddressData checkoutAddressData { get; set; }
        public CheckoutPaymentData checkoutPaymentData { get; set; }

        public DataGeneration()
        {
            createBookData = new CreateBookData(Faker.Name.First(), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 29), Faker.RandomNumber.Next(0, 1), Faker.RandomNumber.Next(1,5));
            messageData = new MessageData(Faker.Name.FullName(), Faker.Internet.Email());
            checkoutAddressData = new CheckoutAddressData(Faker.Name.First(), Faker.Name.Last(), Faker.Address.StreetAddress(), Faker.Address.City(), Faker.Address.ZipCode(), Faker.Phone.Number());
            checkoutPaymentData = new CheckoutPaymentData("424", "123", "12", "17");          
        }     
        
    }
}
