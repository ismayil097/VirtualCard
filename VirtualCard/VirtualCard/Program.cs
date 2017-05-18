using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Card Ismayil = new Card("ISO", new DateTime(2017, 07, 31, 12, 13, 45),500);
            Show.ShowCard(Ismayil);
            var VirtualHesen = Ismayil.AddVirtualCard("Hesen",DateTime.Now.AddDays(30),300);
            Show.ShowCard(VirtualHesen);
            Ismayil.balanceOut(400);
            Console.WriteLine($"Ismayilin pulu {Ismayil.Money.Amount}");
            VirtualHesen.balanceOut(300);
            Console.WriteLine($"Ismayilin pulu {Ismayil.Money.Amount}");
            Console.WriteLine($"Hesenin virtualdaki pulu: {VirtualHesen.Money.Amount}");
        }
    }
}
