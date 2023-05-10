namespace DecoratorPattern
{
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

    
}