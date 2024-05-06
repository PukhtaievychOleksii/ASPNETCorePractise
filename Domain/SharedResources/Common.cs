using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SharedResources
{
    public struct Money
    {
        public Money(double Amount, string Currency)
        {
            this.Amount = Amount;
            this.Currency = Currency;
        }
        private double Amount;
        private string Currency;
    }

}
