namespace sprint10_Task2
{
    public abstract class NotificationService
    {
        public abstract void SendNotification();

    }
    class Customer
    {
        public static void Register(string email, string password)
        {
            MailService mailService = new MailService();
            mailService.Email = email;
            try
            {
                if (mailService.ValidEmail())
                {
                    mailService.SendNotification();

                    SmsService smsService = new SmsService();
                    smsService.SendNotification();
                }
            }
            catch { throw; }
        }
    }

    class MailService : NotificationService
    {
        public string Email { get; set; }
        public string EmailTitle { get; set; } = "User registration";
        public string EmailBody { get; set; } = "Body of message...";
        public override void SendNotification()
        {
            Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}", Email, EmailTitle, EmailBody));
        }
        public bool ValidEmail()
        {
            return Email.Contains("@");
        }
    }

    class SmsService : NotificationService
    {
        public string Number { get; set; } = "111 111 111";
        public string SmsText { get; set; } = "User successfully registered...";

        public override void SendNotification()
        {
            Console.WriteLine(string.Format("Number:{0}, Message:{1}", Number, SmsText));
        }
    }
}