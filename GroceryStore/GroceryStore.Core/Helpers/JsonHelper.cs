using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GroceryStore.Core.Helpers
{
    public static class JsonHelper

    {
        public static T GetData<T>(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    return JsonConvert.DeserializeObject<T>(jsonString);
                }
                else
                {
                    throw new FileNotFoundException($"File not found: {fileName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deserializing JSON: {ex.Message}");
                return default(T);
            }
        }

        public static void SetData<T>(T data, string fileName)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(data);
                File.WriteAllText(fileName, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while serializing JSON: {ex.Message}");
            }
        }
    }

}

