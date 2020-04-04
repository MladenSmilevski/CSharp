using System;
using static Homework_Class_5.Dog;

namespace Homework_Class_5
{
    public static class StringReverse
    {
        public static string ReverseString(string someString)
        {
            char[] Arr = someString.ToCharArray();
            Array.Reverse(Arr);
            return new string(Arr);
        }
    }

    public static class StringCount
    {
        public static string Count(string enteredString)
        {
            int result = 0;
             enteredString = enteredString.Trim();
            if (enteredString == "")
                return "0";
            foreach (string word in enteredString.Split(' '))
                result++;
            string x = $"The number of words in the sentense {enteredString} is {result}.";
            return x;
        }
    }

    public static class StringDivider
    {
        public static string Devide(string devideString)
        {
            string[] words = devideString.Split(',');

            return words[1];

        }
    }

    public static class LeapYear
    {
        public static void Year()
        {
            for (int i = 2008; i < 2021; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine("{0} is a leap year.", i);
                }
            }
        }
    }

    //Create a class Dog

    public class Dog
    {
        public string name;
        public string race;
        public string color;
        public void Eat()
        {
            Console.WriteLine($"The dog is now eating");
        }
        public void Play()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine("The dog is now chasing its tail");
        }

        public class Human
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public void GetPersonStats()
            {
            Console.WriteLine($"Full Name: {FirstName} {LastName} \nAge: {Age}");
            }
        

        }

    }

        class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"The reversed sentence is: " + StringReverse.ReverseString("we love c#"));
            
            Console.WriteLine(StringCount.Count("'we love c#'"));
            
            Console.WriteLine(StringDivider.Devide("The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!"));
            
            Console.WriteLine($"*year = {DateTime.Now.Year} " +
                              $"* month = {DateTime.Now.Month} " +
                              $"* day = {DateTime.Now.Day} " +
                              $"* hour = {DateTime.Now.Hour} " +
                              $"* minute = {DateTime.Now.Minute} " +
                              $"* second = {DateTime.Now.Second}");
            LeapYear.Year();

            var newDog = new Dog();

            Console.WriteLine("Enter dog's name!");
            string name = Console.ReadLine();
            Console.WriteLine("Enter dog's race!");
            string race = Console.ReadLine();
            Console.WriteLine("Enter dog's color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter what the dog is doing? \n1.for PLAYING \n2.for EATING \n3.for chasing it's tail");
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    newDog.Play();
                    break;
                case 2:
                    newDog.Eat();
                    break;
                case 3:
                    newDog.ChaseTail();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter yor last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            var newHuman = new Human();
            newHuman.FirstName = firstName;
            newHuman.LastName = lastName;
            newHuman.Age = age;

            newHuman.GetPersonStats();

            Console.ReadLine();
        }

    }
}
