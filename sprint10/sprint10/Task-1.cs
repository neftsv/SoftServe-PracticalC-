namespace Sprint10_Task1
{
    class Customer
    {
        public void Register(string email, string password)
        {
            try
            {
                MailService mailService = new MailService();
                mailService.SendEmail(email, "Email  title", "Email body");

            }
            catch { throw; }
        }
    }

    class MailService
    {
        public bool ValidEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(string email, string emailTitle, string emailBody)
        {
            if (ValidEmail(email))
                Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}", email, emailTitle, emailBody));
        }
    }
}