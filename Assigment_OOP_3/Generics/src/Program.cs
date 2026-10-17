namespace Generics.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentStore = new Store<Student>();
            studentStore.Add(new Student { Id = 1, Name = "Wael" });
            studentStore.Add(new Student { Id = 2, Name = "Ahmed" });
            studentStore.Add(new Student { Id = 3, Name = "Sara" });
            studentStore.Add(new Student { Id = 4, Name = "Mona" });
            studentStore.Add(new Student { Id = 5, Name = "Kareem" });

            var courseStore = new Store<Course>();
            courseStore.Add(new Course { Id = 101, Title = "C# Basics", Price = 150m });
            courseStore.Add(new Course { Id = 102, Title = "Clean Code", Price = 200m });
            courseStore.Add(new Course { Id = 103, Title = "Design Patterns", Price = 300m });

            var student1 = studentStore.GetById(1);
            Console.WriteLine($"Found Student (ID 1): {student1?.Name}");

            var course102 = courseStore.GetById(102);
            Console.WriteLine($"Found Course (ID 102): {course102?.Title}");

            Console.WriteLine();

            try
            {
                studentStore.Add(new Student { Id = 1, Name = "Duplicate Wael" });
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"[Caught Expected Exception]: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("=== Page 2 (Size 2) of Students ===");
            var page2Students = studentStore.GetAll().Page(2, 2);
            foreach (var student in page2Students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
            }

            Console.WriteLine();

            var plainList = new List<Student>
            {
                new Student { Id = 10, Name = "Ali" },
                new Student { Id = 20, Name = "Omar" }
            };

            var foundInList = plainList.FindById(20);
            Console.WriteLine($"Found in plain List via FindById(20): {foundInList?.Name}");
        }
    }
}
