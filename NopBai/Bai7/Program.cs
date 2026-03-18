namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");

            List<int> dayso = new List<int> { 2, 4, 6, 8, 11, 3 };
            bool coSoLonHon10 = dayso.Any(n => n > 10);
            Console.WriteLine("Danh sach: " + string.Join(", ", dayso));

            Console.WriteLine("Co so nao lon hon 10 khong: " + coSoLonHon10);


        }
    }
}
