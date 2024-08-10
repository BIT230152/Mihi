using System;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen: ");
            int number = int.Parse(Console.ReadLine());

            double double_number = (double)number;

            Console.WriteLine($"So ban da nhap la {number} va o dang kep la {double_number}");
        }
    }
}
