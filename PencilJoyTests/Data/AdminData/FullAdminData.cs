using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.IO;
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
    }
}
