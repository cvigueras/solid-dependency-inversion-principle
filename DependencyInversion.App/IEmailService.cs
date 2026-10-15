namespace DependencyInversion.App
{
    public interface IEmailService
    {
        void SendEmail(User user, string message);
    }
}
