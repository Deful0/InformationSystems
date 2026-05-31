using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InformationSystems
{
    public class MyUtilitis
    {
        // Создание копии объекта
        public static T Clone<T>(T source)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = false
            };

            var json = JsonSerializer.Serialize(source, options);
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
