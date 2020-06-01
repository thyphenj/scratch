using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace scratch
{
    class Program
    {
        static void Main()
        {
            List<Cube> cubes = new List<Cube>();
            for (int i = 3; i * i * i < 100000; i++)
            {
                Cube xx = new Cube(i);
                if (xx.TheValue > 0)
                    cubes.Add(xx);
            }

            cubes = cubes.OrderBy(o => o.TheValue).ToList();

            cubes.FirstOrDefault(x => x.TheValue == 7).Assign('U');
            cubes.FirstOrDefault(x => x.TheValue == 6656).Assign('C');

            int U = cubes.FirstOrDefault(x => x.AssignedTo == 'U').TheValue;
            int C = cubes.FirstOrDefault(x => x.AssignedTo == 'C').TheValue;

            Clue T04 = new Clue(U * U * U);
            Clue A12 = new Clue(C * U - U * U);

            int j = 1;
            foreach (var xx in cubes)
                Console.WriteLine($"{j++,2} : {xx.TheRoot,3} - {xx.TheCube,5} - {xx.TheValue,4}");
        }
        class Cube
        {
            public char AssignedTo;
            public int TheRoot;
            public int TheCube;
            public int TheValue;
            public string Possibles;

            public Cube(int root)
            {
                AssignedTo = ' ';

                TheRoot = root;

                TheCube = root * root * root;

                TheValue = int.Parse(TheCube.ToString().Substring(1));

                Possibles = "";
            }
            public void Assign(char ch)
            {
                AssignedTo = ch;
            }
            public override string ToString()
            {
                return $"{TheValue,4} - {AssignedTo} - {Possibles}";
            }
        }

        class Clue
        {
            public int Value;
            public Clue(int val)
            {
                Value = val;
            }
        }
    }
    //class xxx
    //{
    //    static int
    //        A = 162, B = 649,
    //        C = 54045,
    //        D = 595,
    //        E = 495, F = 69, G = 54, H = 752,
    //        J = 359, K = 573, L = 337,
    //        M = 98, N = 73, P = 395, Q = 55, R = 29,
    //        S = 61, T = 48, U = 44, V = 58,
    //        W = 51, X = 99;

    //    static int
    //        a = 107,
    //        b = 65,
    //        c = 245,
    //        d = 80957,
    //        e = 645,
    //        f = 45,
    //        g = 943,
    //        h = 969,
    //        i = 743,
    //        j = 43,
    //        k = 557,
    //        l = 953,
    //        m = 535,
    //        n = 735,
    //        o = 72,
    //        p = 934,
    //        q = 345,
    //        r = 942,
    //        s = 549,
    //        t = 938,
    //        u = 68,
    //        v = 16,
    //        w = 81,
    //        x = 49,
    //        y = 50,
    //        z = 80;


    //    static int[] digs =
    //            { 1, 6, 2, 8, 6, 4, 9
    //            , 0, 5, 4, 0, 4, 5, 4
    //            , 7, 9, 5, 9, 5, 7, 3
    //            , 4, 9, 5, 6, 9, 5, 5, 4, 7, 5, 2
    //            , 3, 3, 5, 9, 5, 7, 3, 3, 3, 7, 5
    //            , 9, 0 ,7, 3 ,3, 9 ,5, 5 ,5, 2, 9
    //            , 3 ,6, 1 ,4, 8 ,4, 4 ,4, 5 ,8, 3
    //            , 4, 8, 6, 5, 1, 2, 9, 9, 0, 0, 8 };


    //    static void hereWeGo(string[] args)
    //    {
    //        //            runSum();
    //        runString();

    //        if (A != n - K)
    //            Console.WriteLine("A failed");

    //        if (B != o * digSum(o) + 1)
    //            Console.WriteLine("B failed");

    //        if (C != back(C))
    //            Console.WriteLine("C failed");

    //        if (D != back(D))
    //            Console.WriteLine("D failed");

    //        if (E != Q * u - 5 * B)
    //            Console.WriteLine("E failed");

    //        if (F != u + 1)
    //            Console.WriteLine("F failed");

    //        if (digProd(g) % G != 0)
    //            Console.WriteLine("G failed");

    //        if (H != 2 * allDigitSum())
    //            Console.WriteLine("H failed");

    //        if (d != 2 * Q * n + a)
    //        {
    //            Console.WriteLine("d failed");
    //        }
    //    }
    //    static int allDigitSum()
    //    {
    //        int retval = 0;
    //        foreach (int d in digs)
    //            retval += d;
    //        //A + B + C + D + E + F + G + H + J + K + L + M + N + P + Q + R + S + T + U + V + W + X +
    //        //a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w + x + y + z;
    //        return retval;
    //    }
    //    static List<int> digits(int theNum)
    //    {
    //        List<int> retval = new List<int>();
    //        string v = theNum.ToString();
    //        foreach (var x in v)
    //            retval.Add(Int16.Parse(x.ToString()));
    //        return retval;
    //    }
    //    static int digSum(int theNum)
    //    {
    //        int retval = 0;
    //        foreach (var i in digits(theNum))
    //            retval += i;
    //        return retval;
    //    }
    //    static int digProd(int theNum)
    //    {
    //        int retval = 1;
    //        foreach (var i in digits(theNum))
    //            retval *= i;
    //        return retval;
    //    }
    //    static int back(int theNum)
    //    {
    //        return int.Parse(string.Concat(theNum.ToString().Reverse()));
    //    }

    //    //try this for size
    //    static void runSum()
    //    {
    //        int u = 64;

    //        int[] digs =
    //            { 1, 6, 2, 8, 6, 4, 9
    //            , 0, 5, 4, 0, 4, 5, 4
    //            , 7, 9, 5, 9, 5, 7, 3
    //            , 4, 9, 5, 6, 9, 5, 5, 4, 7, 5, 2
    //            , 3, 3, 5, 9, 5, 7, 3, 3, 3, 7, 5
    //            , 9, 0 ,7, 3 ,3, 9 ,5, 5 ,5, 2, 9
    //            , 3 ,6, 1 ,4, 8 ,4, 4 ,4, 5 ,8, 3
    //            , 4, 8, 6, 5, 1, 2, 9, 9, 0, 0, 8 };

    //        int sum = 0;
    //        foreach (int dig in digs)
    //            sum += dig;
    //        Console.WriteLine(2 * sum);
    //        Console.WriteLine();
    //    }

    //    static void runString()
    //    {
    //        int[] letters =
    //            { 16, 28, 64, 90, 54, 04, 54, 79, 59, 57  // good!!
    //            , 34, 95, 69        // ************ BAD E 
    //            , 55, 47, 52
    //            , 33
    //            , 59, 57, 33, 37, 59, 07, 33, 95, 55, 29, 36, 14, 84, 44, 58, 34
    //            , 86
    //            , 51, 29, 90, 08 };

    //        string sa = "";
    //        string sb = "";
    //        string ss = "";
    //        foreach (var lett in letters)
    //        {
    //            sa += (lett / 10).ToString() + " ";
    //            sb += (lett % 10).ToString() + " ";
    //            ss += (char)(lett % 25 + 64) + " ";
    //        }
    //        Console.WriteLine(sa);
    //        Console.WriteLine(sb);
    //        Console.WriteLine(ss);
    //    }


    // int[] primes =
    //        { //2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,
    //     101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193
    //    , 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307
    //    , 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421
    //    , 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547
    //    , 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659
    //    , 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797
    //    , 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929
    //    , 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 };

    //int[] fibs =
    //    { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987};

    //int[] tris =
    //    {1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91 };

    //int[] E0 = { 2, 3, 4, 6 };
    //int[] E3 = { 2, 3, 5, 7 };

    //for ( int clue_u = 60; clue_u < 70; clue_u++)
    //{
    //    for (int mid = 0; mid < 10; mid++)
    //    {
    //        foreach ( int a in E0)
    //            foreach ( int b in E3)
    //            {
    //                int E = a*100 + mid *10 + b;

    //                int clue_E = 55 * clue_u - 5 * 649;

    //                if ( clue_E  == E)
    //                    Console.WriteLine($"{clue_u,2} {clue_E,3}");
    //            }
    //    }
    //}

    //int digSum = digitSum(54045);
    //for ( int i = 1; i < 10; i++)
    //    for ( int j = 1; j < 10; j++)
    //    {
    //        int clue_V = 10 * i + j;
    //        List<int> digs = digits(clue_V);
    //        if ( digs.Count > 1 && digs[0] * digs[1]+digSum == clue_V)
    //            Console.WriteLine(clue_V);
    //    }

    //int[] array = new int[] { 5,  8 };
    //for (int i1 = 0; i1 < array.Length; i1++)
    //{
    //    int i = array[i1];
    //    for ( int j = 0; j < 10; j++)
    //    {
    //        int sum = 10001 * i + 4040 + 100 * j;
    //        foreach ( int k in tris)
    //            if ( k > 9 && sum % k == 0 )
    //                Console.WriteLine($"{sum,5}   {k,2} -- {sum/k,5}");
    //    }
    //}

    //for (int clue_c = 3*49; clue_c < 1000; clue_c+=49)
    //{
    //    List<int> digs = digits(clue_c);
    //    int digprod = digs[0] * digs[1] * digs[2];

    //    if ( digprod > 0 && digprod < 50)
    //        Console.WriteLine($"{clue_c,3} {digprod,3}");
    //}

    //foreach (int clue_k in primes)
    //{
    //    if (clue_k % 10 == 7)
    //    {
    //        var lst = digits(clue_k);
    //        if ( lst[0] == lst[1] || lst[0] == lst[2] || lst[1] == lst[2])
    //            if (lst[1] == 2 || lst[1] == 3 || lst[1] ==4 || lst[1] ==5)
    //                Console.WriteLine(clue_k);
    //    }
    //}

    //for (int clue_J = 5; clue_J < 10; clue_J++)
    //    Console.WriteLine(clue_J * clue_J * clue_J + 16);;

    //foreach (int clue_L in primes)
    //{
    //    if (clue_L.ToString()[1] == '3')
    //    {
    //        int digSum = digitSum(clue_L);
    //        if (fibs.FirstOrDefault(p => p == digSum) == digSum)
    //        Console.WriteLine($"{clue_L}  -  {digSum}");
    //    }
    //}

    //int clue_l = 0;
    //for (int i = 1; clue_l < 2000; i++)
    //{
    //    clue_l += i;
    //    if (clue_l > 1000 && clue_l < 2000 && clue_l % 10 != 0)
    //        Console.WriteLine($"{clue_l - 1000,4}");
    //}

    // }
}
