namespace Generics.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentStore = new Store<Student>();
            studentStore.Add(new Student { Id = 1, Name = "Wael" });

            Console.WriteLine("=== Generic Student Store ===");
            var student = studentStore.GetById(1);
            Console.WriteLine(student != null ? $"Found: {student.Name}" : "Not found");

            // استخدام Store<Course>
            var courseStore = new Store<Course>();
            courseStore.Add(new Course { Id = 101, Title = "Clean Code", Price = 100m });

            Console.WriteLine("\n=== Generic Course Store ===");
            var course = courseStore.GetById(101);
            Console.WriteLine(course != null ? $"Found: {course.Title}" : "Not found");
        }
    }
}
