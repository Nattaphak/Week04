class Program
{
    static void Main(string[] args)
    {
        /* รถ
       Car myCar = new Car();
        myCar.brand = "Toyota";
        myCar.model = "Altis";
        myCar.numberOfDoors = 4;
        myCar.numberOfWheels = 4;

        Car yourCar = new Car();
        yourCar.brand = "Benz";
        yourCar.model = "C200";
        yourCar.numberOfDoors = 2;
        yourCar.numberOfWheels = 4;

        PrintCarInformation(myCar);
        PrintCarInformation(yourCar);
        */
        
        /* ประตูหมา
        DogDoor door = new DogDoor();
        door.Open();
        door.Close();
        Console.WriteLine("Door is Open ? : {0}",door.Isopen());
        */

        Unit ftToInch = new Unit(12);
        Unit mileToft = new Unit(5280);

        Console.WriteLine("Feet To Inches : {0}",ftToInch.Convert(30));
        Console.WriteLine("Miles To Feet : {0}",mileToft.Convert(1));
        Console.WriteLine("Feet To Inches From Miles: {0}",ftToInch.Convert(mileToft.Convert(2)));

    }

    static void PrintCarInformation(Car car)
    {
        Console.WriteLine("*****************************");
        Console.WriteLine("Band: {0}",car.brand);
        Console.WriteLine("Model: {0}",car.model);
        Console.WriteLine("Number of Doors: {0}",car.numberOfDoors);
        Console.WriteLine("Number of Wheels: {0}",car.numberOfWheels);
        Console.WriteLine(car.MoveForward());
        Console.WriteLine(car.MoveBackward());
        Console.WriteLine(car.Turn());
        Console.WriteLine(car.Stop());
        Console.WriteLine("*****************************");
    }
}

