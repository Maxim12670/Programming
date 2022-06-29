using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ProductList.Model;
using System.Windows.Forms;

namespace ProductList.Model
{
    public static class Serializer
    {
        /// <summary>
        /// Путь к папке "AppData".
        /// </summary>
        private static string _appDataFolder = Application.UserAppDataPath;

        /// <summary>
        /// Имя файла.
        /// </summary>
        private static string _nameFile = @"\Serialize.json";

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        public static void Serialize(List<Product> allProducts)
        {
            using (StreamWriter writer = new StreamWriter(_appDataFolder + _nameFile))
            {
                writer.Write(JsonConvert.SerializeObject(allProducts));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию продуктов.</returns>
        public static List<Product> Deserialize()
        {
            var products = new List<Product>();
            try
            {
                using (StreamReader reader = new StreamReader(_appDataFolder + _nameFile))
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
