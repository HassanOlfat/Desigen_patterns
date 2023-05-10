namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a ConcreteComponent object
            Window c = new Window();

            // Wrap ConcreteComponent in a HorizantalWindow object
            HorizantalWindow h = new HorizantalWindow(c);

            // Wrap ConcreteDecoratorA in a VerticalWindow object
            VerticalWindow v = new VerticalWindow(h);

            // Call the operation on the VerticalWindow object
            Console.WriteLine(v.getBrand());

        }
    }

    
}