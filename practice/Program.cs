using System;

namespace practice
{
    class vote
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("enter age of a person");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("you are eligible to vote");
            }
            else
            {
                Console.WriteLine("you are not eligible to vote");
            }
        }
    }
        }
    

