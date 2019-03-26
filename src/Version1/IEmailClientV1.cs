using PipServices3.Commons.Config;
using System.Threading.Tasks;

namespace PipServices.Email.Client.Version1
{
    public interface IEmailClientV1
    {
        Task SendMessageAsync(string correlationId, EmailMessageV1 message, ConfigParams parameters);
        Task SendMessageToRecipientAsync(string correlationId, EmailRecipientV1 recipient, EmailMessageV1 message, ConfigParams parameters);
        Task SendMessageToRecipientsAsync(string correlationId, EmailRecipientV1[] recipients, EmailMessageV1 message, ConfigParams parameters);
    }
}
