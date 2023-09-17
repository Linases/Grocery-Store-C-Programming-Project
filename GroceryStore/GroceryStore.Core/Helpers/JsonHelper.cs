using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
                    return JsonSerializer.Deserialize<T>(jsonString);
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

        public static void SetData<T>( T data,string fileName)
        {
            try
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string jsonString = JsonSerializer.Serialize<T>(data, options);
                File.WriteAllText(fileName, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while serializing JSON: {ex.Message}");
            }
        }
    }

}

