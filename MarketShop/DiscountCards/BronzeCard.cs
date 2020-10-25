using MarketStore.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class BronzeCard : Card
    {
        public BronzeCard(User owner) : base(owner)
        {

        }

        public override double CalculateCurrentDiscount()
        {
            if (this.Turnover < 100)
            {
                return 0;
            }
            else if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                return 1;
            }
            else
            {
                return 2.5;
            }
        }
    }
}
