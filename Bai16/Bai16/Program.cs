namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");
            List<int> dayso = new List<int> { 1, 2, 3, 4, 5 };
            int tong = dayso.Sum();
            Console.WriteLine("Danh sach: " + string.Join(" + ", dayso));
            Console.WriteLine("Tong cac phan tu la: " + tong);
        }
    }
}
