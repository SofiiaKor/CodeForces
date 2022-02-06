using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CodeForces
{
    class Program
    {
        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        private static bool IsAP(int a, int b, int c)
        {
            var delta1 = b - a;
            var delta2 = c - b;

            return delta1 == delta2;
        }

        static void Main(string[] args)
        {
            //3
            var numberOfCases = Convert.ToInt32(Console.ReadLine());

            var a = new List<int>();
            var b = new List<int>();
            var c = new List<int>();
            var answers = new List<bool>();

            for (var i = 0; i < numberOfCases; i++)
            {
                var fl = false;
                var input = Console.ReadLine();
                a.Add(Convert.ToInt32(input.Split(" ")[0]));
                b.Add(Convert.ToInt32(input.Split(" ")[1]));
                c.Add(Convert.ToInt32(input.Split(" ")[2]));

                for (var m = 1; m < 1000000000; m++)
                {
                    if (!IsAP(a[i] * m, b[i], c[i]) && !IsAP(a[i], b[i] * m, c[i]) &&
                        !IsAP(a[i], b[i], c[i] * m)) continue;
                    answers.Add(true);
                    fl = true;
                    break;
                }
                if (!fl)
                    answers.Add(false);
            }

            foreach (var ans in answers)
            {
                Console.WriteLine(ans ? "YES" : "NO");
            }


            //2
            //var w = Convert.ToInt32(Console.ReadLine());

            //if (w < 1 || w > 100)
            //    return;

            //Console.WriteLine(w % 2 == 0 && w/2 % 2 == 0 ? "YES" : "NO");


            //1
            //var numberOfCases = Convert.ToInt32(Console.ReadLine());
            //var l = new List<int>();
            //var r = new List<int>();
            //var k = new List<int>();
            //var answers = new List<string>();

            //for (var i = 0; i < numberOfCases; i++)
            //{
            //    var input = Console.ReadLine();
            //    l.Add(Convert.ToInt32(input.Split(" ")[0]));
            //    r.Add(Convert.ToInt32(input.Split(" ")[1]));
            //    k.Add(Convert.ToInt32(input.Split(" ")[2]));

            //    var a = new List<int>();
            //    for (var j = l[i]; j <= r[i]; j++)
            //        a.Add(j);

            //    var temp = new List<int>();
            //    var fl = false;
            //    for (var z = 1; z <= k[i]; z++)
            //    {
            //        if (fl)
            //            break;

            //        var num1 = a.Max();
            //        if (a.Count <= 1) break;
            //        a.Sort();
            //        var num2 = a[^2];
            //        a.Remove(num1);
            //        a.Remove(num2);
            //        a.Add(num1 * num2);

            //        for (var p = 0; p < a.Count - 1; p++)
            //        {
            //            if (GCD(a[p], a[p + 1]) <= 1) continue;
            //            temp.Add(GCD(a[p], a[p + 1]));
            //            fl = true;
            //            break;
            //        }
            //    }
            //    if (a.Count == 1)
            //    {
            //        temp.Add(a[0]);
            //    }

            //    temp.Add(-1);

            //    answers.Add(temp.Max() > 1 ? "YES" : "NO");
            //}

            //foreach (var str in answers)
            //{
            //    Console.WriteLine(str);
            //}

        }
    }
}
