namespace HelloWorld.Interfaces
{
    public interface IAbstractFactory
    {
        ISubject CreateSubject();
        IObserver CreateObserver();
        ICommand CreateCommand(ISubject subject);
    }
}