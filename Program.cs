
/*У вас есть несколько камней известного веса w1, …, wn. Напишите программу, которая распределит камни в две кучи так, что разность весов этих двух куч будет минимальной.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите кол-во камней: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] stone = new int[n];
            int i, j, sum;
            sum = 0;
            for (i = 0; i < n; i++)
            {
                stone[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum += stone[i];
            }

            int t, current, ans = 2000001;
            for (i = 0; i < Math.Pow(2, n); i++) 
            {
                j = i;
                t = 0;
                current = 0;
                while (j != 0)
                {
                    if (j % 2 == 1)
                    {
                        current += stone[t];
                    }
                    j= j / 2;
                    t++;
                }
                if (Math.Abs(sum - (2 * current)) < ans)
                    ans = Math.Abs(sum - (2 * current));
            }

            Console.Write("Ответ:  \n"+ ans);
            Console.ReadKey();
        }
        
    }
}