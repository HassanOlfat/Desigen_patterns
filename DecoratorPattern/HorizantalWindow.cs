namespace DecoratorPattern
{
    public class HorizantalWindow : WindowDecorator
        {
            public HorizantalWindow(IWindow component) : base(component)
            {
            }

            public string getBrand()
            {
                return "Horizantal Brand";
            }

            public int getSize()
            {
                return 100;
            }
        }

    
}