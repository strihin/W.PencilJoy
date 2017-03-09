namespace PencilJoyTests.Data
{
    public class PaypalPaymentData
    {
        internal string EmailPaypal { get; set; }
        internal string PasswordPaypal { get; set; }

        public PaypalPaymentData(string emailPaypal, string passwordPaypal)
        {
            EmailPaypal = emailPaypal;
            PasswordPaypal = passwordPaypal;
        }
    }
}