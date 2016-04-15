using HelloWorld.Interfaces;

namespace HelloWorld.Library
{
    public class HelloWorldFactory : IAbstractFactory
    {
        public ISubject CreateSubject()
        {
            return new HelloWorldSubject();
        }

        public IObserver CreateObserver()
        {
            return new HelloWorldObserver();
        }

        public ICommand CreateCommand(ISubject subject)
        {
            return new HelloWorldCommand(subject);
        }
    }
}