using PipServices.Email.Client.Version1;
using PipServices3.Commons.Refer;
using PipServices3.Components.Build;

namespace PipServices.Email.Client.Build
{
    public class EmailClientFactory : Factory
    {
        public static Descriptor Descriptor = new Descriptor("pip-services-email", "factoty", "*", "*", "1.0");
        public static Descriptor NullClientV1Descriptor = new Descriptor("pip-services-email", "client", "null", "*", "1.0");
        public static Descriptor HttpClientV1Descriptor = new Descriptor("pip-services-email", "client", "http", "*", "1.0");

        public EmailClientFactory()
        {
            RegisterAsType(NullClientV1Descriptor, typeof(EmailNullClientV1));
            RegisterAsType(HttpClientV1Descriptor, typeof(EmailHttpClientV1));
        }
    }
}
