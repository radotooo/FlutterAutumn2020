using MarketStore.Users;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MarketStore
{
    public abstract class Card
    {
        private readonly User owner;
        private readonly double initialDiscountRate;
        private double turnover;

        public Card(User owner)
        {
            this.owner = owner;
            this.initialDiscountRate = (double)Enum.Parse<CardInitialDiscountRate>(this.GetType().Name);
        }

        public double InitialDiscountRate => this.initialDiscountRate;
        public string Owner => this.owner.FullName;
        public double Turnover => this.turnover;

        public void SetTurnover(double value)
        {
            if (double.IsNaN(value) || value < 0)
            {
                this.turnover = 0;
            }
            else
            {
                this.turnover = value;
            }
        }
        public abstract double CalculateCurrentDiscount();
    }
}
