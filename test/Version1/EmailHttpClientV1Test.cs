using PipServices.Email.Client.Version1;
using PipServices3.Commons.Config;
using System.Threading.Tasks;
using Xunit;

namespace PipServices.Email.Client.Test.Version1
{
    public class EmailHttpClientV1Test
    {
        private static readonly ConfigParams HttpConfig = ConfigParams.FromTuples(
        "connection.protocol", "http",
        "connection.host", "localhost",
        "connection.port", 8080);

        private readonly EmailHttpClientV1 _client;
        private readonly EmailClientFixtureV1 _fixture;

        public EmailHttpClientV1Test()
        {
            _client = new EmailHttpClientV1();
            _client.Configure(HttpConfig);

            _fixture = new EmailClientFixtureV1(_client);

            _client.OpenAsync(null);
        }

        [Fact]
        public async Task TestCrudOperations()
        {
            await _fixture.TestCrudOperationsAsync();
        }

        public void Dispose()
        {
            _client.CloseAsync(null);
        }
    }
}
