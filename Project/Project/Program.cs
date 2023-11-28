namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("John Doe", "123 Main St", DateTime.Now, 12345, "Computer Science");
            Console.WriteLine(student);
        }
    }
}
