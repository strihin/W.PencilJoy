namespace PencilJoyTests.Data
{
    class CheckoutPaymentData
    {
        internal string CreditCardInput { get; set; }
        internal string CardVerifacationValue { get; set; }
        internal int SelectMonth { get; set; }
        internal int SelectYear { get; set; }
        public CheckoutPaymentData()
        {
            CreditCardInput = "4242";
            CardVerifacationValue = Faker.RandomNumber.Next(100, 999).ToString();
            SelectMonth = Faker.RandomNumber.Next(1, 12);
            SelectYear = Faker.RandomNumber.Next(1, 21);
        }
        public CheckoutPaymentData(string creditCardInput, string cardVerifacationValue, int selectMonth, int selectYear)
        {
            CreditCardInput = creditCardInput;
            CardVerifacationValue = cardVerifacationValue;
            SelectMonth = selectMonth;
            SelectYear = selectYear;
        }
       
    }
}
