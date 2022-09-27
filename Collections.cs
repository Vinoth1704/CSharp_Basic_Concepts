using System.Collections;

namespace Learn
{
    class Car
    {
        public string? Make;
        public string? Model;
        public string? VIN;

        public Car(string make, string model, string VIN)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = VIN;
        }

        public Car()
        {

        }

    }

    class Bike
    {
        private int year;
        private string? make { get; set; }
        public Bike(int year, string make)
        {
            this.year = year;
            this.make = make;
        }
    }

    class Collections
    {
        public static void Collection()
        {
            Car car1 = new Car("Skoda", "Rapid", "A1");
            Car car2 = new Car("Volkswagen", "Polo", "B1");
            Bike bike1 = new Bike(2000, "yamaha");

            ArrayList myArrayList = new ArrayList(); //ArrayList allows 
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(bike1);
            /*
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);//This leads to exception because bike1 is also inside myArrayList
            }
            */

            //List<T>
            List<Car> myCarList = new List<Car>();
            myCarList.Add(car1);
            myCarList.Add(car2);
            // myCarList.Add(bike1);//You can't add other class object to this list.
            foreach (Car car in myCarList)
            {
                Console.WriteLine("List " + car.Make);
            }

            //Dictionary<TKey,TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add("A1", car1);
            myDictionary.Add(car2.VIN!, car2);
            Console.WriteLine("Dictionary " + myDictionary["A1"].Make);
            Console.WriteLine("Dictionary " + myDictionary[car2.VIN!].Make);



            //Object initailizer
            Car car3 = new Car() { Make = "Suzuki", Model = "Ciaz", VIN = "F1" };
            Car car4 = new Car() { Make = "Toyota", Model = "Glanza", VIN = "G1" };

            //Collection initializer
            List<Car> myNewCarList = new List<Car>()
            {
                new Car{Make="Honda",Model="City",VIN="C1"},
                new Car{Make="Nissan",Model="GTR",VIN="D1"}
            };
        }
    }
}