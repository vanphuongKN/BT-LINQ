namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");

            List<int> dayso = new List<int> { 8, 3, 1, 6, 2, 7, 4, 5 };
            var sapXepTang = dayso.OrderBy(n => n);
            Console.WriteLine("Danh sách tang dan: " + string.Join(", ", sapXepTang));

        }
    }
}
