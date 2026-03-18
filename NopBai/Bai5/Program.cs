namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");

            List<int> dayso = new List<int> { 1, 2, 3, 4, 5 };
            var binhPhuong = dayso.Select(n => n * n);
            Console.WriteLine("Danh sach ban dau: " + string.Join(" ", dayso));
            Console.WriteLine("Danh sach binh phuong: " + string.Join(" ", binhPhuong));

        }
    }
}
