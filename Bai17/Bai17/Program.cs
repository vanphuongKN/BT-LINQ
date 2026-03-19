namespace Bai17
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
                new Student{Id=4, Name="Dung", Score=7}
            };
            double diemTrungBinh = students.Average(s => s.Score);
            Console.WriteLine("Diem trung binh cua ca lop la: " + diemTrungBinh);
        }
    }
}
