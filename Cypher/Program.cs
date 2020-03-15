using System;
using System.Text;

namespace Cypher
{
    
    class Program
    {
        static void Main(string[] args)
        {
            char[] big = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '};
            char[] sm = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
            Console.WriteLine("Введите слово");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            Console.WriteLine("\n Обработка...");
            StringBuilder sb = new StringBuilder(s1);
            StringBuilder keyedit = new StringBuilder(key);
            for(int i = 0; i < sb.Length; i++)
            {
                for(int j = 0; j < sm.Length; j++)
                {
                    if (sb[i] == sm[j])
                    {
                        sb[i] = big[j];
                    }
                }
            }

            for (int i = 0; i < keyedit.Length; i++)
            {
                for (int j = 0; j < sm.Length; j++)
                {
                    if (keyedit[i] == sm[j])
                    {
                        keyedit[i] = big[j];
                    }
                }
            }


            int keyload = 0;
            int[] keymas = new int[keyedit.Length];

            for (int i = 0; i < keyedit.Length; i++)
            {
                for (int j = 0; j < big.Length; j++)
                {
                    if (keyedit[i] == big[j])
                    {
                        keymas[i] = j;
                    }
                }
            }

            int[] word = new int[sb.Length];

            for (int i = 0; i < sb.Length; i++)
            {
                for (int j = 0; j < big.Length; j++)
                {
                    if (sb[i] == big[j])
                    {
                        word[i] = j;
                    }
                }
            }
            int load = 0;
            for (int i = 0; i < sb.Length; i++)
            {

                if (load == keyedit.Length)
                {
                    load = 0;
                }
                    keyload = word[i] + keymas[load];
                        if (keyload >= big.Length)
                             {
                                  keyload = keymas[load] - word[i];
                                      if (keyload < 0)
                                           {
                        keyload -= 2;
                                               keyload = -keyload;
                                           }
                             }
                    sb[i] = big[keyload];
                load++;
                
            }

            string s2 = sb.ToString();
            string key2 = keyedit.ToString();
            Console.WriteLine("Результат: " + s2 + "\n" + key2);
        }
    }
}
