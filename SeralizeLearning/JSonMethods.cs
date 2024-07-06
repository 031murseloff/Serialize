using CustomerException;
using System.Text.Json;

namespace SeralizeLearning;

public static class JSonMethods
{



   public static void JsonWriteMethod(List<Car> cars)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        var StringJSon = JsonSerializer.Serialize(cars, options);
        File.WriteAllText("cars.json", StringJSon);


    }

    public static List<Car> JSONDerserializemethod()
    {

        string filePath = "cars.json";

        if (!File.Exists(filePath))
        {
            throw new NullpathException("Null path Exception");
            
        }
        List<Car> newCar = null;
        using FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);

        newCar = JsonSerializer.Deserialize<List<Car>>(fs);

        return newCar;
    }

    

}
