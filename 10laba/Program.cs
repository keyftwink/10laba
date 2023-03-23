using _10laba;

namespace _10laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            garage.cars.Add(new Car("Chevrolet Camaro"));
            garage.cars.Add(new Car("Ford Mustang"));
            garage.cars.Add(new Car("Dodge Charger"));

            Delegate washer = new Washer().Wash;

            washer(garage.cars[0]);
            washer(garage.cars[1]);
            washer(garage.cars[2]);

        }
    }
}


delegate void Delegate(Car car);
