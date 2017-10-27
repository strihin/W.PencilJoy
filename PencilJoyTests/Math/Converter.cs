using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PencilJoyTests.Data;
using PencilJoyTests.Math;


namespace PencilJoyTests
{
    class Converter
    {
       static internal int IndexCurrency { get; set; }
       static internal string ActualCurrency { get; set; }
        public Converter() { }

        #region Methods Convert price to int      
        public double RemoveOldPrice(string priceItem)
        {
            int howMuchSpaces = priceItem.Count(c => c == ' ');

            priceItem = RemoveCurrencyFromPrice(priceItem);

            //verify count of dot in price. If 1 dot - 1 price, if 2 dots - 2 prices(old and actual), old price should be removed. Example (200.00 200.00 and 2 000.00)      
            if (howMuchSpaces == 1)
            {
                List<int> dotList = new List<int>();
                for (int i = 0; i < priceItem.Length; i++)
                {
                    if (priceItem[i] == '.')
                        dotList.Add(i);
                }
                priceItem = (dotList.Count > 1)
                    ? priceItem.Substring(priceItem.IndexOf(' ') + 1)
                    : priceItem.Replace(" ", string.Empty);
            }

            //verify 2 price more 1k (ex: 2 000.00 and 3 000.00)
            if (howMuchSpaces == 3)
            {
                List<int> spaceList = new List<int>();
                for (int i = 0; i < priceItem.Length; i++)
                {
                    if (priceItem[i] == ' ')
                        spaceList.Add(i);
                }
                priceItem = priceItem.Substring(spaceList[1]);
            }
            return ConvertStringToDouble(priceItem);
        }

        public double ConvertStringToDouble(string priceItem)
        {
            priceItem = priceItem.Replace(" ", string.Empty);
            priceItem = priceItem.Replace(".", ",");
            return Convert.ToDouble(priceItem);
        }

        public string RemoveCurrencyFromPrice(string priceWithCurrency)
        {
            List<string> currencySymbols = new List<string>();
            foreach (var currency in FullAdminData.CurrencyList)
            {
                currencySymbols.Add(currency.currencySymbol);
            }
            foreach (var c in currencySymbols)
            {
                priceWithCurrency = priceWithCurrency.Replace(c, string.Empty);
            }
            return priceWithCurrency;
        }
        public double GetDigit(string priceWithCurrency)
        {
            Regex digitsOnly = new Regex(@"[^\d .]");
            return Convert.ToDouble(digitsOnly.Replace(priceWithCurrency, ""));
        }

        public double ConvertTotalPrice(string priceWithCurrency, double priceTheFirstBook)
        {
            ActualCurrency = GetCurrency(priceWithCurrency, priceTheFirstBook);
            priceWithCurrency = RemoveCurrencyFromPrice(priceWithCurrency);
            return RemoveOldPrice(priceWithCurrency);
        }

        public  string GetCurrency(string priceWithCurrency, double priceTheFirstBook)
        {
            string actualCurrency = String.Empty;
            foreach (var currency in FullAdminData.CurrencyList)
            {
                if (priceWithCurrency.Contains(currency.currencySymbol) && priceTheFirstBook.Equals(currency.currencyValue))
                {
                    actualCurrency = currency.currencySymbol;
                    break;
                }
            }
            return actualCurrency;
        }
        public  double GetDiscount(string discountCode)
        {
            double actualCode = GetDigit(discountCode);
            foreach (var discount in FullAdminData.DiscountCodeList)
            {
                if (actualCode.Equals(discount.CodeValue))
                {
                    return actualCode;
                }
            }
            return -1;
        }
        public string RandomCurrency()
        {
            Random ra = new Random();
            IndexCurrency = ra.Next(0, FullAdminData.CurrencyList.Count - 1);
            return FullAdminData.CurrencyList[IndexCurrency].currencyName;
        }

       
        #endregion

    }
}
