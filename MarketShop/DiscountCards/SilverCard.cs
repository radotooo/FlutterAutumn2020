using MarketStore.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class SilverCard : Card

    {
        public SilverCard(User owner) : base(owner)
        {
        }

        public override double CalculateCurrentDiscount()
        {
            if (this.Turnover > 300)
            {
                return 3.5;
            }
            return this.InitialDiscountRate;
        }
    }
}
