using PipServices.Email.Client.Version1;
using PipServices3.Commons.Config;
using System.Threading.Tasks;
using Xunit;

namespace PipServices.Email.Client.Test.Version1
{
    public class EmailClientFixtureV1
    {
        private EmailMessageV1 EMAILMESSAGE1 = new EmailMessageV1("somebody@somewhere.com", "{{subject}}", "{{text}}", "<p>{{text}}</p>");
        private EmailRecipientV1 EMAILRECIPIENT1 = new EmailRecipientV1("1", "Test Recipient", "somebody@somewhere.com");

        private IEmailClientV1 _client;

        public EmailClientFixtureV1(IEmailClientV1 client)
        {
            this._client = client;
        }

        public async Task TestCrudOperationsAsync()
        {
            var parameters = ConfigParams.FromTuples(
            "subject", "Test Email To Address",
            "text", "This is just a test"
            );

            await this._client.SendMessageAsync(null, EMAILMESSAGE1, parameters);
            Assert.True(!this._client.SendMessageAsync(null, EMAILMESSAGE1, parameters).IsFaulted);

            await this._client.SendMessageToRecipientAsync(null, EMAILRECIPIENT1, EMAILMESSAGE1, null);
            Assert.True(!this._client.SendMessageToRecipientAsync(null, EMAILRECIPIENT1, EMAILMESSAGE1, null).IsFaulted);
        }
    }
}
