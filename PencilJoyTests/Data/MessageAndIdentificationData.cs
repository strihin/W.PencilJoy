using System.Collections;
using System.Collections.Generic;

namespace PencilJoyTests.Data
{
    class MessageAndIdentificationData
    {
        internal string CustomerName { get; set; }
        internal string CustomerEmail { get; set; }
        internal string CustomerPassword { get; set; }
        internal List<string> Message { get; set; }

        public MessageAndIdentificationData()
        {
            CustomerName = Faker.Name.FullName();
            CustomerEmail = Faker.Internet.Email();
            Message = new List<string>();
            for (int i = 0; i < Faker.RandomNumber.Next(1, 6); i++)
            {
                Message.Add(Faker.Lorem.Paragraph()+'\n');
            }
        }

        public MessageAndIdentificationData(string customerEmail, string customerPassword)
        {
            CustomerEmail = customerEmail;
            CustomerPassword = customerPassword;
        }
        public MessageAndIdentificationData(string customerEmail, string customerPassword, List<string> message)
        {
            CustomerEmail = customerEmail;
            CustomerPassword = customerPassword;
            Message = message;
        }
    }
}
