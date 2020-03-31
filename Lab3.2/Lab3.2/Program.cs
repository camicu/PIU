using System;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                string[][] mat = new string[26][];
                int[] n = new int[26];

                for (int i = 0; i < 26; i++)
                {
                    mat[i] = new string[20];
                }

                foreach(var v in args)
                {
                    int i = (int)v[0];
                    if((i>=65&&i<91))
                    {
                        mat[i-65][n[i-65]] = v;
                        n[i-65]++;
                    }
                    if(i >= 97 && i <= 122)
                    {
                        mat[i - 97][n[i - 97]] = v;
                        n[i - 97]++;
                    }
                }
               
                
                Console.WriteLine("Cuvintele sunt : \n");
                for(int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < n[i]; j++)
                    {
                        Console.Write("{0} ", mat[i][j]);
                    }
                    if (n[i] != 0)
                    {
                        Console.WriteLine();
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
