using System;
using System.Linq;

namespace BrainTeasers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hi Friend. Sorry about not being able to teach you much these past few weeks. Hopefully this will be enlightening. 
            // So, this code is crap. The variables are not named correctly... So, you might want to refactor it to improve naming as you figure out how it works. 
            //   I did leave the type declarations next to all the variables to make it a little more understandable.
            // Just figure out how it is working and then maybe try to implement the same thing in a different way. 

            Console.WriteLine("Please type something and press ENTER.");
            string a = Console.ReadLine();

            DoSomething(a);


            Console.WriteLine("Done! Press ENTER to exist.");
            Console.ReadLine();
        }

        private static void DoSomething(string a)
        {
            if(a.Count() == 0)
            {
                return;
            }

            char b = a.First();

            int c = a.Count(x => x == b);

            Console.WriteLine($"{b}:{c}");

            char[] d = a.Where(x => x != b).ToArray();

            string e = new string(d);

            DoSomething(e);
        }
    }
}
