using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Code = int.Parse(Console.ReadLine()); //число от 32 до 127
            Console.WriteLine((char)Code);
        }
    }
}
