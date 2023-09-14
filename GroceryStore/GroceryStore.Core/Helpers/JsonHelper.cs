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
        public static T GetData<T>(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<T>(jsonString);
                }
                else
                {
                    throw new FileNotFoundException($"File not found: {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deserializing JSON: {ex.Message}");
                return default(T);
            }
        }

        public static void SetData<T>(string filePath, T data)
        {
            try
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string jsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while serializing JSON: {ex.Message}");
            }
        }
    }

}

