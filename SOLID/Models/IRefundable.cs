using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.SOLID.Models
{
    interface IRefundable
    {
        void Refund(decimal amount);
    }
}
