namespace Bl
{
    public interface IEmailSenderr
    {
        public void SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
