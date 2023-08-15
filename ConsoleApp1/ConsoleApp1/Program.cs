
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Faska", "Bahramov", 19);
            student.Learn();

            var teacher = new Teacher("Niyazi", "Babayev", 21);
            teacher.Explain();

        }
    }
}