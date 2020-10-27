using MarketStore.Users;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MarketStore
{
    public class GoldCard : Card
    {
        public GoldCard(User owner) : base(owner)
        {
        }
        public override double CalculateCurrentDiscount()
        {
            var discountGrow = 1;
            var amount = 100;
            var capping = 10;

            var result = this.InitialDiscountRate + (discountGrow * (this.Turnover / amount));

            if (result > capping)
            {
                return capping;
            }
            return Math.Floor(result);
        }
    }
}
