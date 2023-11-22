using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint10_Task3
{
    public interface INotification
    {
        void SendNotification();
    }

    public interface INotificationToDB
    {
        void AddNotificationToDB();
    }
    public abstract class NotificationService: INotification, INotificationToDB
    {
        public abstract void SendNotification();
        public abstract void AddNotificationToDB();
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

        public override void AddNotificationToDB()
        {
            //Don`t write any
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
        public override void AddNotificationToDB()
        {
            //throw new Exception("Not alowed");
        }
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
                    mailService.AddNotificationToDB();
                    SmsService smsService = new SmsService();
                    smsService.SendNotification();
                    smsService.AddNotificationToDB();
                }
            }
            catch { throw; }
        }
    }
}