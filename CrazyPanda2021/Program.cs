using System;
using System.Collections.Generic;

namespace CrazyPanda2021
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<uint> _list = new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }; //11
            //List<uint> _list = new List<uint> { 4, 5, 6, 7 }; //18
            //List<uint> _list = new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }; //88
            CrazyPanda2021Functions func = new CrazyPanda2021Functions();

            //List<uint> _list = new List<uint> { 0 };
            ulong _sum = 11;
            int _start;
            int _end;
            uint x;
            DateTime _start_DateTime = DateTime.Now;
            //Random rnd = new Random();

            //for (int i = 0; i < 1000000; i++)
            //{
            //    x = (uint)rnd.Next(1, 100);
            //    _list.Add(x);
            //}

            Console.WriteLine($" generate done:\t  { DateTime.Now - _start_DateTime}");
            _start_DateTime = DateTime.Now;
            func.FindElementsForSum(_list, _sum, out _start, out _end);
            Console.WriteLine($" FindElementsForSum done:\t  { DateTime.Now - _start_DateTime}");
            Console.WriteLine(_start + " - " + _end);

        }
    }
}
