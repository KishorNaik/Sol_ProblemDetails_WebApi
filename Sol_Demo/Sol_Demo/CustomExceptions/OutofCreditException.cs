using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.CustomExceptions
{
    public class OutofCreditException : Exception
    {
        public OutofCreditException() : base()
        {
        }

        public double Cost { get; set; }
        public double Balance { get; set; }

        public String Description { get; set; }

        public OutofCreditException(string message, double cost, double balance) : base(message)
        {
            this.Cost = cost;
            this.Balance = balance;

            Description = $"Your current balance is {Balance}, but the costs {Cost}";
        }

        public OutofCreditException(string message) : base(message)
        {
        }

        public OutofCreditException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}