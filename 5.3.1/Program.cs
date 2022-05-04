using System;

namespace _5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var somename = "Evgeniya";
            Console.WriteLine(somename);

            GetName(ref somename);
            Console.WriteLine(somename);
            var someage = 30;
            Console.WriteLine(someage);
            ChangeAge(someage);
            Console.WriteLine(someage);
        }
        static void GetName(ref string name)
        {
            Console.WriteLine("Insert your name");
            name = Console.ReadLine();
        }
        static int ChangeAge(int age)
        {
            Console.WriteLine("Insert your age");
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }            
    }
}
