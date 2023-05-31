namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new();
            factory.GetFlyweight("Test1").Operation("ex1");
            factory.GetFlyweight("Test2").Operation("ex2");
            factory.GetFlyweight("Test3").Operation("ex3");
            ////////////////////////////////////////////////////////
            UnsharedConcreteFlyweight flyweights = new(new Flyweight[]
            {
                factory.GetFlyweight("T1"),
                factory.GetFlyweight("T2"),
                factory.GetFlyweight("T3"),
               
            });
            flyweights.Operation("ex");

            Console.ReadKey();
        }
    }
    public abstract class Flyweight
    {
        public abstract void Operation(string extrisicstate);
    }
    public class ConcreteFlyweight : Flyweight
    {
        private string _intrinsicState;
        public ConcreteFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }
        public override void Operation(string extrisicstate)
        {
            Console.WriteLine($"ConcreteFlyweight.Operation('{_intrinsicState}'):{extrisicstate}");
        }
    }
    public class UnsharedConcreteFlyweight : Flyweight
    {
        private IEnumerable<Flyweight> _flyweights;
        public UnsharedConcreteFlyweight(IEnumerable<Flyweight> flyweights)
        {
            _flyweights = flyweights;
        }
        public override void Operation(string extrisicstate)
        {
            Console.WriteLine($"UnsharedConcreteFlyweight.Operation():{extrisicstate}");
            foreach (var item in _flyweights)
            {
                item.Operation(extrisicstate);
            }
        }
    }

    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights = new Dictionary<string, Flyweight>();
        public Flyweight GetFlyweight(string key)
        {
            Flyweight flyweight = null;
            if (_flyweights.TryGetValue(key, out flyweight) ) { }
            else
            {
                _flyweights.Add(key, new ConcreteFlyweight(key));
            }
            return _flyweights[key];
        }
    }
}