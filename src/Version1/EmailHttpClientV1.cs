using PipServices3.Commons.Config;
using PipServices3.Rpc.Clients;
using System.Threading.Tasks;

namespace PipServices.Email.Client.Version1
{
    public class EmailHttpClientV1 : CommandableHttpClient, IEmailClientV1
    {
        private ConfigParams _defaultParameters;

        public EmailHttpClientV1() : base("v1/email")
        { }

        public EmailHttpClientV1(object config) : base("v1/email")
        {
            ConfigParams thisConfig = ConfigParams.FromValue(config);
            this._defaultParameters = thisConfig.GetSection("parameters");
            if (config != null) this.Configure(thisConfig);
        }

        public async Task SendMessageAsync(string correlationId, EmailMessageV1 message, ConfigParams parameters)
        {
            using (var timing = Instrument(correlationId))
            {
                await CallCommandAsync<Task>(
                    "send_message",
                    correlationId,
                    new
                    {
                        message = message,
                        parameters = parameters
                    }
                    );
            }
        }

        public async Task SendMessageToRecipientAsync(string correlationId, EmailRecipientV1 recipient, EmailMessageV1 message, ConfigParams parameters)
        {
            using (var timing = Instrument(correlationId))
            {
                await CallCommandAsync<Task>(
                    "send_message_to_recipient",
                    correlationId,
                    new
                    {
                        recipient = recipient,
                        message = message,
                        parameters = parameters
                    }
                    );
            }
        }

        public async Task SendMessageToRecipientsAsync(string correlationId, EmailRecipientV1[] recipients, EmailMessageV1 message, ConfigParams parameters)
        {
            using (var timing = Instrument(correlationId))
            {
                await CallCommandAsync<Task>(
                    "send_message_to_recipients",
                    correlationId,
                    new
                    {
                        recipients = recipients,
                        message = message,
                        parameters = parameters
                    }
                    );
            }
        }
    }
}
