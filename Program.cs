using System;

namespace Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string subject = Console.ReadLine();
            Students students = new Students("Khalitov Islam", subject);
            Students students1 = new Students("Khalitov Islam", subject);
            Students students2 = new Students("Khalitov Islam", subject);
            Console.WriteLine(students.GetName(subject) + students.Count);
            Console.WriteLine(students1.GetName(subject) + students1.Count);
        }
    }
}
