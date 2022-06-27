using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ProductList.Model.Classes;
using System.Windows.Forms;

namespace ProductList.Model.Classes
{
    public static class Serializer
    {
        private static string _appDataFolder = Application.UserAppDataPath;
        public static void Serialize(List<Product> allProducts)
        {
            using (StreamWriter writer = new StreamWriter(_appDataFolder + @"\Serialize.json"))
            {
                writer.Write(JsonConvert.SerializeObject(allProducts));
            }
        }
        public static List<Product> Deserialize()
        {
            var products = new List<Product>();

            try
            {
                using (StreamReader reader = new StreamReader(_appDataFolder + @"\Serialize.json"))
                {
                    products = JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
                }

                if (products == null) products = new List<Product>();
            }
            catch
            {
                return products;
            }

            return products;
        }
    }
}
