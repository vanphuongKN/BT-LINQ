namespace Bai20
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong - 225LTC02#");

            List<Student> students = new List<Student>() {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=7},
                new Student{Id=5, Name="Em", Score=9.5},
                new Student{Id=6, Name="Phuc", Score=5}
            };
            var top3SinhVien = students.OrderByDescending(s => s.Score).Take(3).ToList();
            Console.WriteLine("Top 3 sinh vien diem cao nhat:");
            foreach (var sv in top3SinhVien)
            {
                Console.WriteLine($"- {sv.Name}: {sv.Score} diem");
            }
        }
    }
}
