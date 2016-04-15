using System.Collections.Generic;
using HelloWorld.Interfaces;

namespace HelloWorld.Library
{
    public class HelloWorldSubject : ISubject
    {
        private readonly List<IObserver> _observers;
        private string _message;

        public HelloWorldSubject()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(this));
        }

        public string GetMessage()
        {
            return _message;
        }

        public void SetMessage(string message)
        {
            _message = message;
            NotifyObservers();
        }
    }
}