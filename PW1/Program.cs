public class Car
{
    private double maxSpeed;
    private string name;

    public Car(double maxSpeed, string name)
    {
        this.maxSpeed = maxSpeed;
        this.name = name;
    }

    public void propertyCar()
    {
        Console.WriteLine($"Скорость: {maxSpeed} км/ч, название {name}");
    }


    public static void Main()
    {
        Console.WriteLine($"В гонке участвует 4 тачки:");

        Car CarFirst = new Car(120, "Vaz2108");
        CarFirst.propertyCar();

        Car CarSecond = new Car(150, "Nissan Almera");
        CarSecond.propertyCar();

        Car CarThird = new Car(300, "White Prior with low clearance ");
        CarThird.propertyCar();

        Car CarFourth = new Car(90, "Gazzel");
        CarFourth.propertyCar();


        Console.WriteLine("");


        if (CarFirst.maxSpeed > CarSecond.maxSpeed && CarFirst.maxSpeed > CarThird.maxSpeed && CarFirst.maxSpeed > CarFourth.maxSpeed)
        {
            Console.WriteLine($"Победил: {CarFirst.name}");
        }
        else if (CarSecond.maxSpeed > CarFirst.maxSpeed && CarSecond.maxSpeed > CarThird.maxSpeed && CarSecond.maxSpeed > CarFourth.maxSpeed)
        {
            Console.WriteLine($"Победил: {CarSecond.name}");
        }
        else if (CarThird.maxSpeed > CarFirst.maxSpeed && CarThird.maxSpeed > CarSecond.maxSpeed && CarThird.maxSpeed > CarFourth.maxSpeed)
        {
            Console.WriteLine($"Победил: {CarThird.name}");
        }
        else if (CarFourth.maxSpeed > CarFirst.maxSpeed && CarFourth.maxSpeed > CarSecond.maxSpeed && CarFourth.maxSpeed > CarThird.maxSpeed)
        {
            Console.WriteLine($"Победил: {CarFourth.name}");
        }
    }
}

