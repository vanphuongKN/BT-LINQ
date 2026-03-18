namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");

            List<int> dayso = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int soLuongChan = dayso.Count(n => n % 2 == 0);
            Console.WriteLine("Danh sach: " + string.Join(", ", dayso));
            Console.WriteLine("So luong phan tu chan la: " + soLuongChan);
        }
    }
}
