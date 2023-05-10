namespace DecoratorPattern
{
    public class VerticalWindow : WindowDecorator
        {
            public VerticalWindow(IWindow component) : base(component)
            {
            }

            public string getBrand()
            {
                return "Vertical Brand";
            }

            public int getSize()
            {
                return 200;
            }
        }

    
}