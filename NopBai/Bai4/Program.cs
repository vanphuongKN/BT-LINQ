namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");
            List<int> dayso = new List<int> { 1, 5, 2, 8, 3, 7, 4, 6 };
            var sapXepGiam = dayso.OrderByDescending(n => n);
            Console.WriteLine("Danh sach giam dan: " + string.Join(", ", sapXepGiam));


        }
    }
}
