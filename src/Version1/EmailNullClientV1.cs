using System.Threading.Tasks;
using PipServices3.Commons.Config;

namespace PipServices.Email.Client.Version1
{
    public class EmailNullClientV1 : IEmailClientV1
    {
        public Task SendMessageAsync(string correlationId, EmailMessageV1 message, ConfigParams parameters)
        {
            return DoNothingAsync();
        }

        public Task SendMessageToRecipientAsync(string correlationId, EmailRecipientV1 recipient, EmailMessageV1 message, ConfigParams parameters)
        {
            return DoNothingAsync();
        }

        public Task SendMessageToRecipientsAsync(string correlationId, EmailRecipientV1[] recipients, EmailMessageV1 message, ConfigParams parameters)
        {
            return DoNothingAsync();
        }

        private Task DoNothingAsync()
        {
            return Task.Delay(0);
        }
    }
}
