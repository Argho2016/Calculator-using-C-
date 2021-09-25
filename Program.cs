using System;

namespace Class_C
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string name = "Hasan";
            int age = 30;
            Console.WriteLine("Enter user name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter user age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Clear();
           
            Console.WriteLine("User name is " + name + "\nUser age is " + age);
            Console.WriteLine("User age is " + age);
            Console.WriteLine("User name is {0} \nUser age is {1}", name, age);*/

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect Command");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();



        }
        //Addition
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }

        //Subtration
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
    }
}
