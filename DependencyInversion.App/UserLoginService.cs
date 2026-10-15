namespace DependencyInversion.App
{
    public class UserLoginService
    {
        private readonly IEmailService _emailService;

        public UserLoginService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public User Login(string userName, string password)
        {
            //Do login
            var user = new User();
            _emailService.SendEmail(user, "Bienvenido de nuevo");
            return user;
        }
    }
}
