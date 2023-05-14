namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy();
           
            subject.DoAction();

            Console.WriteLine("Hello, World!");
        }
    }
}