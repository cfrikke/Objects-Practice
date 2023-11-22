namespace Vehicles
{
    public class Vehicle
    {
        private string make;
        private string model;
        private int year;
        private string color;
        protected int numberOfTires;


        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }


        public void MoveForward()
        {
            Console.WriteLine("The " + GetVehicleTitle() + " drives forward.");
        }
        public void TurnRight()
        {
            Console.WriteLine("The " + GetVehicleTitle() + " turns right.");
        }
        public void TurnLeft()
        {
            // Complete this method to output "The *vehicle title* turns left."
            Console.WriteLine("The " + GetVehicleTitle() + " is starting to move...");
        }


        public void MoveBackwards()
        {
            Console.WriteLine("The " + GetVehicleTitle() + " drives in backwards.");
        }


        public string GetVehicleTitle()
        {
            return this.year + " " + this.make + " " + this.model;
        }


        public void Brake()
        {
            Console.WriteLine("The " + this.GetVehicleTitle() + " comes to a halt.");
        }


        public void Honk()
        {
            Console.WriteLine("Honk!");
        }


        public void PrintNumTiresString()
        {
            Console.WriteLine("The " + this.GetVehicleTitle() + " has " + numberOfTires + " tires.");
        }


        public string GetMake()
        {
            return this.make;
        }
        public string GetModel()
        {
            return this.model;
        }


        public int GetYear()
        {
            return this.year;
        }
    }
}
