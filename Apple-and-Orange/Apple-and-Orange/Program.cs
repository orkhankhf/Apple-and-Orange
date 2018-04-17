using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        var LarryCount = 0;
        var RobCount = 0;

        for (int i = 0; i < apples.Count(); i++)
        {
            if (apples[i] > 0)
            {
                if (a + apples[i] >= s && a + apples[i] <= t)
                {
                    LarryCount++;
                }
            }
        }

        for (int i = 0; i < oranges.Count(); i++)
        {
            if (oranges[i] < 0)
            {
                if ((b + oranges[i]) <= t && (b + oranges[i]) >= s)
                {
                    RobCount++;
                }
            }
        }

        Console.WriteLine(LarryCount);
        Console.WriteLine(RobCount);
    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apple = Array.ConvertAll(Console.ReadLine().Split(' '), appleTemp => Convert.ToInt32(appleTemp))
        ;

        int[] orange = Array.ConvertAll(Console.ReadLine().Split(' '), orangeTemp => Convert.ToInt32(orangeTemp))
        ;
        countApplesAndOranges(s, t, a, b, apple, orange);
    }
}

