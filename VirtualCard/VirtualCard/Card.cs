using System;
using System.Collections.Generic;

namespace VirtualCard
{
    class Card
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string CVC { get; set; }
        public DateTime DeadLine { get; set; }
        public Balance Money = new Balance();
        public Balance VirtualBalance = new Balance();
        public List<VirtualCard> virtualList = new List<VirtualCard>();
   



        public virtual void balanceOut(int amount)
        {
            
            if (amount <= Money.Amount)
            {
                Money.Amount -= amount;
                for (int i = 0; i < virtualList.Count; i++)
                {
                    if (virtualList[i].Money.Amount>this.Money.Amount)
                    {
                        virtualList[i].Money.Amount = this.Money.Amount;
                    }
                }
            }
            else
            {
                Console.WriteLine("balansinizi artirin...");
            }
           
        }

        public virtual void balanceIn(int amount)
        {
            Money.Amount += amount;

        }

        public Card()
        {

        }

        public Card(string name,DateTime deadLine,double money)
        { 
            Name = name;
            DeadLine = deadLine;
            Money.Amount = money;
            CVC = Randomize.randomNumber(3);
            CardNumber = Randomize.randomNumber(16);
        }
        
        public VirtualCard AddVirtualCard(string virtualName, DateTime virtualDeadLine, double virtualMoney)
        {
            
            VirtualBalance.Amount += virtualMoney;
            if (VirtualBalance.Amount <= Money.Amount)
            {
                VirtualCard obj = new VirtualCard(virtualName, virtualDeadLine, virtualMoney,this);
                obj.DeadLine = DeadLine;
                virtualList.Add(obj);
                return obj;
            }
            else
            {
                Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur\n");
                return null;
            }
        }
    }
}
