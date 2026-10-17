using Generics.src;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Step 1: StudentStore ===");
            var store = new StudentStore();
       
            store.Add(new Student { Id = 1, Name = "Ahmed Wael" });
            store.Add(new Student { Id = 2, Name = "Mohamed Ali" });

            Console.WriteLine("\n=== Get Student By Id = 1 ===");
            var found = store.GetById(1);
            Console.WriteLine(found != null ? $"Found: {found.Name}" : "Not found");

            Console.WriteLine("=== All Students ===");
            foreach (var student in store.GetAll())
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
            }

            store.Remove(1);
            Console.WriteLine("\n=== After Removing Student Id = 1 ===");
            foreach (var student in store.GetAll())
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
            }
        }
    }
}
