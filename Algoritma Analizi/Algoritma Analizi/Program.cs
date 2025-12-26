using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Analizi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hedef metin yaz.\n");
            Program nesne = new Program();
            nesne.kelime();
        }

        public void kelime()
        {
            string input1 = Console.ReadLine();
            Console.WriteLine(ara(input1));
            Console.ReadLine();
        }

        bool ara(string deger)
        {
            int i = 3;
            int length = deger.Length;
            while (i < length)
            {
                switch (deger[i])
                {
                    case 'D':

                        if (deger[i - 1] == 'C' &&
                        deger[i - 2] == 'B' &&
                        deger[i - 3] == 'A')
                        {
                            return true;
                        }

                        i += 4;
                        continue;
                    case 'C':

                        i += 1;
                        continue;
                    case 'B':

                        i += 2;
                        continue;
                    case 'A':

                        i += 3;
                        continue;
                    default:

                        i += 4;
                        continue;
                }
            }

            return false;
        }

        bool kontrol(string value)
        {
            return value.IndexOf("ABCD", StringComparison.Ordinal) != -1;
        }
    }
}
