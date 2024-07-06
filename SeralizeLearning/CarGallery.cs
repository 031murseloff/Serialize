using CustomerException;
using System.Dynamic;

namespace SeralizeLearning;

public class CarGallery
{

    public string Name { get; set; }

    public List<Car> cars = new();
  
    public void AddToJsonFile(Car car)
    {
        this.cars=JSonMethods.JSONDerserializemethod();
        cars.Add(car);
        JSonMethods.JsonWriteMethod(this.cars);
      
    }

    public void RemoveForId(int id)
    {
        this.cars = JSonMethods.JSONDerserializemethod();

        if (this.cars == null)
        {
            throw new NullInputException("It cannot be Null");
        }

        Car carToRemove = null;

        foreach (var mycar in cars)
        {
            if (mycar.Id == id)
            {
                carToRemove = mycar;
                break;
            }
        }

        if (carToRemove != null)
        {
            cars.Remove(carToRemove);
        }

        JSonMethods.JsonWriteMethod(this.cars);
    }

    public void GetAll()
    {
        List<Car> TempList = JSonMethods.JSONDerserializemethod();

        foreach (var car in TempList)
        {
            Console.WriteLine(car);
        }

    }

    public Car carGetById(int id)
    {
        List<Car> TempList =JSonMethods.JSONDerserializemethod(); 

        foreach (var car in TempList)
        {
            if(car.Id == id)
            {
                return car;
            }
        }

        throw new NotFoundException("qeyd edilen id de car tapilmadi");
    }






}
