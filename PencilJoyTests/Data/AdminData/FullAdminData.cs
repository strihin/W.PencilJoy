using System;
using System.Collections.Generic;
using System.IO;
using PencilJoyTests.Data.AdminData;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace PencilJoyTests.Data
{
    static class FullAdminData
    {
        internal static List<DiscountCode> DiscountCodeList { get; set; }
        internal static List<Currency> CurrencyList { get; set; }
        
        public static string GetPath(string jsonFileName)
        {
            string localPath = new Uri(System.Reflection.Assembly.GetCallingAssembly().CodeBase).LocalPath;
            string actualPath = localPath.Substring(0, localPath.LastIndexOf("bin")) + "Data\\AdminData\\" + jsonFileName;
            return actualPath;
        }
        public static List<T> DeSerializeCurrency<T>(List<T> dataList, string fileName)
        {
            dataList = new List<T>();
            string filePath = GetPath(fileName);
            if (File.Exists(filePath))
            {
                String JSONtxt = File.ReadAllText(filePath);
                dataList = JsonConvert.DeserializeObject<List<T>>(JSONtxt);
            }
            return dataList;
        }
        public static void LoadJson()
        {
            DiscountCodeList = DeSerializeCurrency<DiscountCode>(DiscountCodeList, "DiscountCode.json");
            CurrencyList = DeSerializeCurrency<Currency>(CurrencyList, "Currencies.json");
        }
        public static List<string> GetCurrencySymbolList()
        {
            List<string> symbolList = new List<string>();
            foreach (var currencyItem in CurrencyList)
            {
                symbolList.Add(currencyItem.currencySymbol);
            }
            return symbolList;
        }

        public static bool IsValidPrice(double actualPrice, string actualCurrency)
        {
            foreach (var currencyItem in CurrencyList)
            {
                if (actualPrice == currencyItem.currencyValue && actualCurrency == currencyItem.currencySymbol)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
