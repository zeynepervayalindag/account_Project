using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hesapadi = { "Zeynep Erva YALINDAĞ", "Rümeysa YALINDAĞ", "Sümeyye YALINDAĞ", "Mustafa YALINDAĞ", "Yasemin YALINDAĞ" };
            Sifre nesne1 = new Sifre(hesapadi);
        }
    }
    class Sifre
    {
        public Sifre(string[] hesapadi)
        {
            Random rnd = new Random();
            for (int j = 0; j < hesapadi.Length; j++)
            {
                
                char[] dizi = new char[8];
                for (int i = 0; i < dizi.Length; i++)
                {
                    int x = rnd.Next(0, 3);
                    if (x == 0)
                    {
                        int y = rnd.Next(48, 58);
                        dizi[i] = Convert.ToChar(y);
                    }
                    else if (x == 1)
                    {
                        int y = rnd.Next(65, 91);
                        dizi[i] = Convert.ToChar(y);
                    }
                    else if (x == 2)
                    {
                        int y = rnd.Next(97, 123);
                        dizi[i] = Convert.ToChar(y);
                    }
}
                Console.Write("{0} isimli kullanıcının hesabının şifresi ", hesapadi[j]);
                Console.WriteLine(dizi);
}
            
        }
}
}
