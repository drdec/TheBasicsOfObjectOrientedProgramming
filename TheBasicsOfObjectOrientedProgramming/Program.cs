using System;
using TheBasicsOfObjectOrientedProgramming;

namespace Homework
{
    public class Program
    {
        public static void Main()
        {
            Student student = new("Anton", "Grinkevich", 19, "M", 2, 7.4);

            student.PrintInfo();
        }
    }
}