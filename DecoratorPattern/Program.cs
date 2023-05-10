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
        public interface IWindow
        {
            int getSize();
        }
        public class Window : IWindow
        {
            public int getSize()
            {
                return 20;
            }
        }


        // The base decorator class
        public abstract class WindowDecorator : IWindow
        {
            private IWindow _component;

            public WindowDecorator(IWindow component)
            {
                _component = component;
            }

            public virtual int getSize()
            {
                return _component.getSize();
            }


        }



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