using PipServices3.Commons.Config;
using PipServices3.Commons.Refer;
using PipServices3.Rpc.Clients;
using System.Threading.Tasks;

namespace PipServices.Email.Client.Version1
{
    public class EmailDirectClientV1 : DirectClient<dynamic>, IEmailClientV1
    {
        private ConfigParams _defaultParameters;

        public EmailDirectClientV1() : base()
        { }

        public EmailDirectClientV1(object config) : base()
        {
            this._dependencyResolver.Put("controller", new Descriptor("pip-services-email", "controller", "*", "*", "*"));
            ConfigParams thisConfig = ConfigParams.FromValue(config);
            this._defaultParameters = thisConfig.GetSection("parameters");
            if (config != null) this.Configure(thisConfig);
        }

        public Task SendMessageAsync(string correlationId, EmailMessageV1 message, ConfigParams parameters)
        {
            parameters = this._defaultParameters.Override(parameters);
            return this._controller.SendMessageAsync(correlationId, message, parameters);
        }

        public Task SendMessageToRecipientAsync(string correlationId, EmailRecipientV1 recipient, EmailMessageV1 message, ConfigParams parameters)
        {
            parameters = this._defaultParameters.Override(parameters);
            return this._controller.SendMessageToRecipientAsync(correlationId, recipient, message, parameters);
        }

        public Task SendMessageToRecipientsAsync(string correlationId, EmailRecipientV1[] recipients, EmailMessageV1 message, ConfigParams parameters)
        {
            parameters = this._defaultParameters.Override(parameters);
            return this._controller.SendMessageToRecipientsAsync(correlationId, recipients, message, parameters);
        }
    }
}
