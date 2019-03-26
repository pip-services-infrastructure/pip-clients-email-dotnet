using PipServices3.Commons.Data;
using System.Runtime.Serialization;

namespace PipServices.Email.Client.Version1
{
    [DataContract]
    public class EmailRecipientV1 : IStringIdentifiable
    {
        public EmailRecipientV1() { }

        public EmailRecipientV1(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public EmailRecipientV1(string id, string name, string email, string language) : this(id, name, email)
        {
            Language = language;
        }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }
    }
}