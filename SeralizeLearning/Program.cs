
using SeralizeLearning;
using System.Text;
using System.Text.Json;
using System.Xml;


CarGallery carGallery = new CarGallery();
Car newCar1= new Car(1,"Lada","011",2000);
Car newCar2= new Car(2,"Bmw","f10",2010);
Car newCar3= new Car(3,"Merc","Gl350",2015);
Car newCar4= new Car(4,"Kia","Optima",2020);

carGallery.cars.Add(newCar1);

JSonMethods.JsonWriteMethod(carGallery.cars);

carGallery.AddToJsonFile(newCar2);
carGallery.AddToJsonFile(newCar3);
carGallery.AddToJsonFile(newCar4);

carGallery.RemoveForId(newCar1.Id);
//Console.WriteLine(carGallery.carGetById(newCar2.Id) );

carGallery.GetAll();





