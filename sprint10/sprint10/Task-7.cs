using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint10_Task7
{
    public interface IFileLogger
    {
        public void Check()
        {
        }

        public void Debug()
        {
        }

        public void Info()
        {
        }
    }
    class Invoice
    {
        public long Amount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void Add()
        {
            Console.WriteLine("Adding amount...");
            string mailMessage = "Your invoice is ready.";
            MailSender.SendEmail(mailMessage);
        }

        public void Delete()
        {
            Console.WriteLine("Deleting amount...");
        }
    }

    class FileLogger: IFileLogger
    {
        public void Check()
        {
        }

        public void Debug()
        {
        }

        public void Info()
        {
        }
    }

    class MailSender
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public static void SendEmail(string mailMessage)
        {
            Console.WriteLine("Sending Email: {0}", mailMessage);
        }
    }
}
