namespace PencilJoyTests.Data
{
    class MessageData
    {
        internal string CustomerName { get; set; }
        internal string CustomerEmail { get; set; }

        public MessageData(string customerName, string customerEmail)
        {
            CustomerName = customerName;
            CustomerEmail = customerEmail;
        }
    }
}
