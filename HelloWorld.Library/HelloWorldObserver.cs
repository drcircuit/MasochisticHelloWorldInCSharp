using System;
using HelloWorld.Interfaces;

namespace HelloWorld.Library
{
    public class HelloWorldObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            HelloWorldSubject sub = subject as HelloWorldSubject;
            Console.WriteLine(sub?.GetMessage());
        }
    }
}