using System;

namespace 수암호화프로그램
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetPassword(100000));
        }

        static int GetPassword(int number) => (int)(Math.Sqrt(number) * 1_000) - number;
    }
}
