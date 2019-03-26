using System.Runtime.Serialization;

namespace PipServices.Email.Client.Version1
{
    [DataContract]
    public class EmailMessageV1
    {
        public EmailMessageV1() { }

        public EmailMessageV1(string to, object subject, object text, object html)
        {
            To = to;
            Subject = subject;
            Text = text;
            Html = html;
        }

        public EmailMessageV1(string from, string cc, string bcc, string to, string replyTo, object subject, object text, object html)
        {
            From = from;
            Cc = cc;
            Bcc = bcc;
            To = to;
            ReplyTo = replyTo;
            Subject = subject;
            Text = text;
            Html = html;
        }

        [DataMember(Name = "from")]
        public string From { get; set; }

        [DataMember(Name = "cc")]
        public string Cc { get; set; }

        [DataMember(Name = "bcc")]
        public string Bcc { get; set; }

        [DataMember(Name = "to")]
        public string To { get; set; }

        [DataMember(Name = "reply_to")]
        public string ReplyTo { get; set; }

        [DataMember(Name = "subject")]
        public object Subject { get; set; }

        [DataMember(Name = "text")]
        public object Text { get; set; }

        [DataMember(Name = "html")]
        public object Html { get; set; }
    }
}
