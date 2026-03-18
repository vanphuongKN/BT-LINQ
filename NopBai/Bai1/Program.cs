namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC#02 ");

            List<int> dayso = new List<int>() { 1, 2,3,4,5,6,7,8,9};
            var sochan = dayso.Where(n => n % 2 == 0);
            Console.WriteLine("So chan: " + string.Join(",", sochan));


        }
    }
}
