using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Purchase
    {
        private readonly Card card;
        private double purchaseValue;
        public Purchase(Card card, double value)
        {
            this.card = card;
            this.PurchaseValue = value;
        }
        private double PurchaseValue
        {
            set
            {
                if (value < 0)
                {
                    this.purchaseValue = 0;
                }
                else
                {
                    this.purchaseValue = value;
                }
            }
        }

        public double DiscountRate()
        {
            return this.card.CalculateCurrentDiscount();
        }
        public double Discount()
        {
            return DiscountRate() / 100 * this.purchaseValue;
        }
        public double TotalPrice()
        {
            return this.purchaseValue - Discount();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Purchase value: ${this.purchaseValue:F2}");
            sb.AppendLine($"Discount rate: {DiscountRate():F1}%");
            sb.AppendLine($"Discount: ${Discount():F2}");
            sb.AppendLine($"Total: ${TotalPrice():F2}");
            return sb.ToString();
        }
    }
}
