using System;

namespace VirtualCard
{
    class Show
    {
        public static void ShowCard(Card CardName)
        {
            Console.WriteLine($"Adi: " +
                $"{ CardName.Name}\nKartin seriyasi: " +
                $"{CardName.CardNumber}" +
                $"\nKartin bitme tarixi: " +
                $"{CardName.DeadLine}\nKartin Shifresi: " +
                $"{CardName.CVC}\n" +
                $"Kartin balansi: {CardName.Money.Amount}\n");
                
        }
        public static void ShowCard(VirtualCard CardName)
        {
            if (CardName != null)
            {
                Console.WriteLine($"Adi: " +
                $"{ CardName.Name}\nKartin seriyasi: " +
                $"{CardName.CardNumber}" +
                $"\nKartin bitme tarixi: " +
                $"{CardName.DeadLine}\nKartin Shifresi: " +
                $"{CardName.CVC}\n" +
                $"Kartin balansi: {CardName.Money.Amount}\nHesab muddeti: " +
                $"{(CardName.UseTime - DateTime.Now).Days}\n");
            }
                

        }
    }
}
