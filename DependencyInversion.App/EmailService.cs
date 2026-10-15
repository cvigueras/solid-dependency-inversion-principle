namespace DependencyInversion.App
{
    public class EmailService : IEmailService
    {
        public void SendEmail(User user, string message)
        {
            //Send Email to User
            Console.WriteLine($"Email enviado: {message}");
        }
    }
}
