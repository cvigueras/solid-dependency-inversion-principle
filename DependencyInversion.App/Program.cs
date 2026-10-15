using DependencyInversion.App;

IEmailService emailService = new EmailService();
var userLoginService = new UserLoginService(emailService);

userLoginService.Login("carlos", "1234");
