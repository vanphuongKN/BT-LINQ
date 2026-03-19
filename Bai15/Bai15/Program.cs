namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");

            List<int> dayso = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var danhSachDuyNhat = dayso.Distinct().ToList();
            Console.WriteLine("Danh sach ban dau: " + string.Join(" ", dayso));
            Console.WriteLine("Danh sach duy nhat: " + string.Join(" ", danhSachDuyNhat));

        }
    }
}
