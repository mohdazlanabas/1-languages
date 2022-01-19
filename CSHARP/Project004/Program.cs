using System;

namespace Project004
{
    class Program
    {
        public static void Main(string[] args)
        {
            //OBJECTS METHOD

            Student student1  = new Student("Jim", "Business", 2.4);
            Student student2  = new Student("Pam", "Art", 3.7);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}
