using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
namespace TooGoodDataParser.Utilities
{
    public static class JsonLoader<T>
    {

        public static T buildFromJson()
        {
            var className = typeof(T).Name;
            var root = Directory.GetCurrentDirectory();
            var filePath = string.Format("{0}\\Jsons\\{1}.json", root, className);
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
