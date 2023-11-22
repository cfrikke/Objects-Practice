namespace Vehicles
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string make, string model, int year) : base(make, model, year)
        {
            numberOfTires = 2;
        }


        public void Pedal()
        {
            Console.WriteLine("Starting to pedal the " + this.GetVehicleTitle());
        }
        public void Honk()
        {
            Console.WriteLine("honk");
        }
    }
}
