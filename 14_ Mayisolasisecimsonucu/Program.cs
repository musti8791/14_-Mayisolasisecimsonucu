using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14__Mayisolasisecimsonucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int akPartiOy = 0;
            int mhpOy = 0;
            int chpOy = 0;
            int iyiPartiOy = 0;

            Console.WriteLine("Hangi partiye oy vermek istersiniz?");
            Console.WriteLine("1 - Ak Parti");
            Console.WriteLine("2 - Mhp");
            Console.WriteLine("3 - Chp");
            Console.WriteLine("4 - İyi Parti");

            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                akPartiOy++;
            }
            else if (secim == 2)
            {
                mhpOy++;
            }
            else if (secim == 3)
            {
                chpOy++;
            }
            else if (secim == 4)
            {
                iyiPartiOy++;
            }

            Random random = new Random();
            int toplamOy = akPartiOy + mhpOy + chpOy + iyiPartiOy;

            while (toplamOy < 100)
            {
                int rastgeleParti = random.Next(1, 5);

                if (rastgeleParti == 1)
                {
                    akPartiOy++;
                }
                else if (rastgeleParti == 2)
                {
                    mhpOy++;
                }
                else if (rastgeleParti == 3)
                {
                    chpOy++;
                }
                else if (rastgeleParti == 4)
                {
                    iyiPartiOy++;
                }

                toplamOy++;
            }

            int cumhurIttifakiOy = akPartiOy + mhpOy;
            int milletIttifakiOy = chpOy + iyiPartiOy;

            Console.WriteLine("Cumhur İttifakı Oy Oranı: %" + (100.0 * cumhurIttifakiOy / toplamOy));
            Console.WriteLine("Millet İttifakı Oy Oranı: %" + (100.0 * milletIttifakiOy / toplamOy));

            if (cumhurIttifakiOy > milletIttifakiOy && cumhurIttifakiOy >= toplamOy / 2)
            {
                Console.WriteLine("Cumhur İttifakı iktidar oldu!");
            }
            else if (milletIttifakiOy > cumhurIttifakiOy && milletIttifakiOy >= toplamOy / 2)
            {
                Console.WriteLine("Millet İttifakı iktidar oldu!");
            }
            else
            {
                Console.WriteLine("Seçimlerden sonuç çıkmadı!");
            }

            Console.ReadLine();
        }
    }
}
    

