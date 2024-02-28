// MailRequest.cs

namespace Vehicle_Configurator.Models
{
    public class MailRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        // public string Subject { get; set; }
        public string msgBody { get; set; }
        public List<IFormFile>? Attachments { get; set; }
    }
}
