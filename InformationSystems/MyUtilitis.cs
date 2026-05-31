using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace InformationSystems
{
    public class MyUtilitis
    {
        // Создание копии объекта
        public static T Clone<T>(T source)
        {
            var json = JsonSerializer.Serialize(source);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
