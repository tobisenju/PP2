using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_b
{
    class counter
    {
        string name;
        string ID;
        int course;

        public counter(string name, string ID, int course)
        {
            this.name = name;
            this.ID = ID;
            this.course = course;
        }
        public void answer()
        {
            Console.WriteLine("Student's name: {0}", name);
            Console.WriteLine("Srudent's ID: {0}", ID);
            if (course == 4) Console.WriteLine("You're near to take bachelor diploma!");
            if (course > 4) Console.WriteLine("You've already finished your study");
            if (course < 4 && course >= 1)
            {
                course++;
                Console.WriteLine("Next year will be {0} for you", course);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter your name , ID and course : ");
                counter cnt = new counter(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                cnt.answer();
                Console.WriteLine("Press any key to continue ");
                Console.ReadKey();
            }
        }
    }
}
