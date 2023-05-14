namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        private RealSubject RealSubject;

        public void DoAction()
        {
            if (RealSubject == null)
            {
                RealSubject = new RealSubject();
            }
            RealSubject.DoAction();
        }
    }
}