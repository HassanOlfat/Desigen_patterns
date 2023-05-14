namespace ProxyPattern
{
    public class RealSubject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("RealSubject.DoAction() is Run....");
        }
    }
}