using System.Globalization;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");


            List<int> dayso = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var lonHon5 = dayso.Where(n => n > 5).ToList();

            Console.WriteLine(string.Join(", ", lonHon5));
        }
    }
}
