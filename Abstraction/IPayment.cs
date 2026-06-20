using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Interface
{
    public interface IPayment
    {
        void Pay();
    }
    public class PhonePo : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment via PhonePe");
        }
    }
    public class GooglePay : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment via GooglePay");
        }
    }
    public class Swiggy
    {
        public void ProcessPayment(IPayment payment)
        {
            payment.Pay();
        }
    }
}
