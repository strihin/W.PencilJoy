namespace PencilJoyTests.Data
{
    class CheckoutPaymentData
    {
        internal string CreditCardInput { get; set; }
        internal string CardVerifacationValue { get; set; }
        internal string SelectMonth { get; set; }
        internal string SelectYear { get; set; }

        public CheckoutPaymentData(string creditCardInput, string cardVerifacationValue, string selectMonth, string selectYear)
        {
            CreditCardInput = creditCardInput;
            CardVerifacationValue = cardVerifacationValue;
            SelectMonth = selectMonth;
            SelectYear = selectYear;
        }
    }
}
