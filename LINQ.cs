namespace Learn
{
    class LINQ
    {
        public static void LinqQuery(List<Car> myCars)
        {
            //Select 
            var skodaCars = from Car in myCars where Car.Make == "Skoda" select Car;
            // PrintList(skodaCars);

            //Sorting
            var sortedCars = from Car in myCars orderby Car.Make descending select Car;
            // PrintList(sortedCars);


        }
        public static void LinqMethod(List<Car> myCars)
        {
            //Select
            var skodaCars = myCars.Where(p => p.Make == "Skoda");
            // PrintList(skodaCars);

            //Sorting
            var sortedCars = myCars.OrderBy(p => p.Make);
            // PrintList(sortedCars);

            //First
            var FirstCar = myCars.First(c => c.Make == "Skoda");
            Console.WriteLine(FirstCar.Model);

            //ForEach loop
            myCars.ForEach(c => Console.WriteLine($"Linq Query ForEach Method : Make = {c.Make}, Model = {c.Model}, VIN = {c.VIN}"));

        }

        public static void PrintList(IEnumerable<Car> Cars)
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"Linq Query : Make = {car.Make}, Model = {car.Model}, VIN = {car.VIN}");
            }
        }
        public static void Linq()
        {
            Car car1 = new Car("Skoda", "Rapid", "A1");
            Car car2 = new Car("Skoda", "Fabia", "B1");
            Car car3 = new Car("Volkswagen", "Polo", "C1");
            Car car4 = new Car("Volkswagen", "Vento", "D1");
            Car car5 = new Car("Suzuki", "Ciaz", "E1");
            List<Car> myCars = new List<Car>();
            myCars.Add(car1);
            myCars.Add(car2);
            myCars.Add(car3);
            myCars.Add(car4);
            myCars.Add(car5);
            LinqMethod(myCars);
            LinqQuery(myCars);
        }
    }
}