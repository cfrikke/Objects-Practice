public class Program {
    public static void Main() {
            Car myCar = new Car("Ford", "Explorer", 2005);
            Semi mySemi = new Semi("Kenworth", "T680 Next Gen", 2022);
            Bicycle bike = new Bicycle("Schwinn", "Clubman", 1953);


            myCar.On();
            myCar.Drive();
            myCar.PrintNumTiresString();


            mySemi.On();
            mySemi.Drive();
            mySemi.Off();
            mySemi.PrintNumTiresString();
           
            bike.Pedal();
            bike.Brake();
            bike.Honk();
            bike.PrintNumTiresString();

    }
}