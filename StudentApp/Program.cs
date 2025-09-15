namespace StudentApp
{
    internal class Program
    {
        //Default constructor is provided 
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new ();
            var costas = new Student();

            Student student = new();
            Student student1 = new(1,"Alice", "W.");

            Student student2 = new() { Id = 2, Firstname = "Giannis"};

            Teacher teacher = new() { Id = 1, Firstname = "Petros", Lastname = "Lyros" };
            teacher.Id = 2;
            teacher.Firstname = "Olia";
            teacher.Lastname = "Dak";

            Console.WriteLine($"Id = {teacher.Id}, Firstname : {teacher.Firstname}, Lastname = {teacher.Lastname}");
            

        }
    }
}
