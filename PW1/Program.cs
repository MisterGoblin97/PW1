namespace PW1
{
    class Car
    {
        public double maxSpeed;
        public string name;

        public Car(double maxSpedd,string name)
        { 
            this.maxSpeed = maxSpedd;
            this.name = name;
        }

        public  void propertyCar(double maxSpeed, string name)
        {
            Console.WriteLine("Speed: " + maxSpeed + " Name: " + name);
        }




        static void Main()
        {
            Car CarFirst = new(120, "Vaz2108");
           
            Console.WriteLine(CarFirst.propertyCar);
        }
    }
}
