namespace Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");

            List<int> dayso = new List<int> { 1, 5, 2, 3, 3, 4, 3, 5, 2, 3, 1 };
            var soXuatHienNhieuNhat = dayso.GroupBy(n => n).OrderByDescending(g => g.Count()) .FirstOrDefault();
            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", dayso));
            if (soXuatHienNhieuNhat != null)
            {
                Console.WriteLine($"So xuat hien nhieu nhat la: {soXuatHienNhieuNhat.Key}");
                Console.WriteLine($"So lan xuat hien: {soXuatHienNhieuNhat.Count()} lan");
            }
            else
            {
                Console.WriteLine("Danh sach rong!");
            }
        }
    }
}
