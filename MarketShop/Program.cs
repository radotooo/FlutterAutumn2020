using MarketStore.Users;
using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Ivan Ivanov");

            var bronzeCard = new BronzeCard(user);
            var sivelrCard = new SilverCard(user);
            var goldCard = new GoldCard(user);


            try
            {
                bronzeCard.SetTurnover(0);
                sivelrCard.SetTurnover(600);
                goldCard.SetTurnover(1500);
            }
            catch (Exception e)
            {

                throw new InvalidOperationException(e.Message);
            }

            try
            {
                var purchaseWithBronze = new Purchase(bronzeCard, 150);
                var purchaseWithSilver = new Purchase(sivelrCard, 850);
                var purchaseWithGold = new Purchase(goldCard, 1300); ;

                Console.WriteLine(purchaseWithBronze.Report());
                Console.WriteLine(purchaseWithSilver.Report());
                Console.WriteLine(purchaseWithGold.Report());
            }
            catch (Exception e)
            {

                throw new InvalidOperationException(e.Message);
            }

        }
    }
}
