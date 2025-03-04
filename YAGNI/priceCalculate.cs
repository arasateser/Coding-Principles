using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.YAGNI
{

    //YAGNI: You Ain't Gonna Need It
    //do not add functionalities unless you reallly need it
    //in example below we are adding values that we do not need for
    //price calculation yet. that means we do not know if
    //we will need it in the future or not
    //as best practice its better to not include any not-used values in our code
    public decimal priceCalculate(decimal price, int quantity, bool isLoyaltyMember, decimal discountPercentage = 0)
    {
        decimal total = price * quantity;

        // Future feature: Apply discount for loyalty members
        if (isLoyaltyMember)
        {
            total -= total * (discountPercentage / 100);
        }

        return total;
    }
}
