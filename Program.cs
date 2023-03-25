namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Лада Калина", "Белая", "о778оо");
            Car car2 = new Car("Хонда Аккорд", "Черная","a999дд");
            Car car3 = new Car("Жигули", "Баклажановая", "к000кс");

            Garage garage = new Garage();

            garage.AddCar(car1);
            garage.AddCar(car2);
            garage.AddCar(car3);

            garage.DeleteCar(car1);

            Washer washer = new Washer();

            garage.WashCars(washer.Wash);

        }
    }
    class Car
    {
        public string name { get; set; }
        public string color { get; set; }
        public string number { get; set; }

        public Car(string name, string color, string number)
        {
            this.name = name;
            this.color = color;
            this.number = number;
        }
    }

    class Washer
    {
        public void Wash(Car car) => Console.WriteLine($"Помывка машины - {car.name}, цвет - {car.color}, гос.номер - {car.number}");
    }

    class Garage
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car) => cars.Add(car);

        public void DeleteCar(Car car) => cars.Remove(car);

        public void WashCars(WashDelegate washDelegate)
        {
            foreach (Car car in cars)
            {
                washDelegate(car);
            }
        }

        public delegate void WashDelegate(Car car);
    }
}