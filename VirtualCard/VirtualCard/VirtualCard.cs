using System;

namespace VirtualCard
{
    class VirtualCard : Card
    {
        Card Parent;

        public override void balanceOut(int amount)
        {
           
            if (amount <= Money.Amount)
            {
                this.Money.Amount -= amount;
                Parent.balanceOut(amount);
            }
            else
            {
                Console.WriteLine("Biraz daha pul gotur esas kartdan");
            }
        }

        


        public DateTime UseTime { get; set; }
        public VirtualCard(string virtualName, DateTime useTime, double virtualMoney,Card parent)
            :base(virtualName, useTime, virtualMoney)
        {
            Parent = parent;
            Console.WriteLine(base.Name);
            Name = virtualName;
            UseTime = useTime;      
            Money.Amount = virtualMoney;
            CVC = Randomize.randomNumber(3);
            CardNumber = Randomize.randomNumber(16);         
        }
    }
}
