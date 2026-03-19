namespace Bai12
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC#02");

            List<Student> students = new List<Student>()
            {
                new Student { Id = 1,Name = "An", Score = 8 },
                new Student { Id = 2,Name = "Binh ", Score = 6 },
                new Student { Id = 3,Name = "Chi ", Score = 9 },
                new Student { Id = 4,Name = "Dung", Score = 7 }
            };
            int soluongDat = students.Count(s => s.Score >= 7);
            Console.WriteLine("So luong sinh vien co diem lon hon 7 la: " + soluongDat);

        }
    }
}
