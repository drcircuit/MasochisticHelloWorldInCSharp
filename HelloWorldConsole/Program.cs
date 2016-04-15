using System;
using Factories;
using HelloWorld.Interfaces;

namespace HelloWorldConsole
{
    class HelloWorldProgram
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory = FactoryMakerSingleton.Me.GetFactory();
            ISubject subject = factory.CreateSubject();
            subject.Attach(factory.CreateObserver());
            ICommand command = factory.CreateCommand(subject);
            command.Execute();
            Console.Read();
        }
    }
}
