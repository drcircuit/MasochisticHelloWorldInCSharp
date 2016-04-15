using Factories;
using HelloWorld.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTest
{
    [TestClass]
    public class HelloWorldCommandTest
    {
        private IAbstractFactory _factory = FactoryMakerSingleton.Me.GetFactory();

  

        [TestMethod]
        public void FactoryCreatesObserver()
        {
            var observer = _factory.CreateObserver();
            Assert.IsNotNull(observer);
        }

        [TestMethod]
        public void FactoryCreatesSubject()
        {
            var subject = _factory.CreateSubject();
            Assert.IsNotNull(subject);
        }

        [TestMethod]
        public void FactoryCreatesCommand()
        {
            var subject = _factory.CreateSubject();
            var command = _factory.CreateCommand(subject);
            Assert.IsNotNull(command);
        }

        [TestMethod]
        public void SubjectCanAttachObservers()
        {
            var subject = _factory.CreateSubject();
            subject.Attach(_factory.CreateObserver());
        }
    }
}
