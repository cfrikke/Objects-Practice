namespace Vehicles
{
    public class Car : GasPoweredVehicle
    {
        public Car(string make, string model, int year) : base(make, model, year)
        {
            numberOfTires = 4;
        }
    }
}


