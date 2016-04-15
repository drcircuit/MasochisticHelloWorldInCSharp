using HelloWorld.Interfaces;
namespace HelloWorld.Library
{
    public class HelloWorldCommand : ICommand
    {
        private HelloWorldSubject _subject;
        public HelloWorldCommand(ISubject subject)
        {
            _subject = (HelloWorldSubject) subject;
        }

        public void Execute()
        {
            _subject.SetMessage(Resources.HelloWorld.Messages.PrimaryMessage);
        }
    }
}