using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint10_Task_8
{
    interface IDiscount
    {
        double ApplyDiscount(double amount);
    }

    class FinalInvoice : Invoice, IDiscount
    {
        public double GetDiscount(double amount)
        {
            return ApplyDiscount(amount);
        }
        public double ApplyDiscount(double amount)
        {
            return amount - amount * 0.03;
        }
    }

    class ProposedInvoice : Invoice, IDiscount
    {
        public double GetDiscount(double amount)
        {
            return ApplyDiscount(amount);
        }
        public double ApplyDiscount(double amount)
        {
            return amount - amount * 0.05;
        }
    }

    class RecurringInvoice : Invoice, IDiscount
    {

        public double GetDiscount(double amount)
        {
            return ApplyDiscount(amount);
        }
        public double ApplyDiscount(double amount)
        {
            return amount - amount * 0.1;
        }
    }

    class OrdinaryInvoice : Invoice, IDiscount
    {
        public double GetDiscount(double amount)
        {
            return ApplyDiscount(amount);
        }
        public double ApplyDiscount(double amount)
        {
            return amount - amount * 0.01;
        }
    }

    class Invoice
    {
        private readonly IDiscount discount;


        public double GetDiscount(double amount)
        {
            return discount.ApplyDiscount(amount);
        }
    }

    class p
    {
        static void Main(string[] args)
        {

            FinalInvoice finInv = new FinalInvoice();
            Console.WriteLine("Amount for final invoice = {0}", finInv.GetDiscount(1000));
        }
    }
}
