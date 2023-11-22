namespace Vehicles{
    public class Semi : GasPoweredVehicle {
        public Semi(string make, string model, int year) : base(make, model, year)
        {
            numberOfTires = 18;
        }


        public void Honk(){
            Console.WriteLine("HONK!!");
        }
    }
}
