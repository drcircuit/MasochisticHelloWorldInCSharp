

using HelloWorld.Interfaces;
using HelloWorld.Library;

namespace Factories
{
    public class FactoryMakerSingleton
    {
        private static FactoryMakerSingleton _me;
        private readonly IAbstractFactory _factory;
        private FactoryMakerSingleton()
        {
            _factory = new HelloWorldFactory();
        }

        public IAbstractFactory GetFactory()
        {
            return _factory;
        }
        public static FactoryMakerSingleton Me
        {
            get { return _me ?? (_me = new FactoryMakerSingleton()); }
        }
    }
}