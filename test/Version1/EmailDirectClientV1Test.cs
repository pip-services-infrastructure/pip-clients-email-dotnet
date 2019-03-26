using PipServices.Email.Client.Version1;
using PipServices3.Commons.Refer;
using PipServices3.Components.Log;
using Xunit;

namespace PipServices.Email.Client.Test.Version1
{
    public class EmailDirectClientV1Test
    {
        private readonly EmailDirectClientV1 _client;
        private readonly EmailClientFixtureV1 _fixture;

        public EmailDirectClientV1Test()
        {
            //var persistence = new EmailMemoryPersistence();
            //var controller = new EmailController();

            //References references = References.FromTuples(
            //    new Descriptor("pip-services-settings", "persistence", "memory", "default", "1.0"), persistence,
            //    new Descriptor("pip-services-settings", "controller", "default", "default", "1.0"), controller

            //);
            //controller.SetReferences(references);
            var logger = new ConsoleLogger();
            References references = References.FromTuples(
                new Descriptor("pip-services", "logger", "console", "default", "1.0"), logger
            );

            _client = new EmailDirectClientV1();
            _client.SetReferences(references);

            _fixture = new EmailClientFixtureV1(_client);

            var clientTask = _client.OpenAsync(null);
            //clientTask.Wait();
        }

        //[Fact]
        //public void TestCrudOperations()
        //{
        //    var task = _fixture.TestCrudOperationsAsync();
        //    //task.Wait();
        //}

        public void Dispose()
        {
            var task = _client.CloseAsync(null);
            //task.Wait();
        }
    }
}
