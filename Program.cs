using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Students
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)

            { 
            //Create a list containing each student, their number, hometown and favorite food

            List<Student> studentData = new List<Student>();
            Student a = new Student("Molly", 1, "Rockford", "Noodles");
            Student b = new Student("Michelle", 2, "Ecuador", "Spaghetti");
            Student c = new Student("Rebecca", 3, "Charlevoix", "Pizza");
            Student d = new Student("Brianna", 4, "Fairfield", "Gumbo");
            Student e = new Student("Tammy", 5, "Grand Rapids", "Maru Sushi");
            Student f = new Student("Lauren", 6, "Plainwell", "Cheeseburgers");
            Student g = new Student("Karina", 7, "Holland", "Tacos");
            Student h = new Student("Anel", 8, "Grand Rapids", "Pizza");
            Student i = new Student("Tommy", 9, "Raleigh", "Indian Red Curries");
            Student j = new Student("Lisa", 10, "Los Angeles", "Mushroom Masala Dosa");
            Student k = new Student("Jonaca", 11, "Lansing", "Sushi");
            Student l = new Student("Tanvi", 12, "India", "Chicken Biryani");

            studentData.Add(a);
            studentData.Add(b);
            studentData.Add(c);
            studentData.Add(d);
            studentData.Add(e);
            studentData.Add(f);
            studentData.Add(g);
            studentData.Add(h);
            studentData.Add(i);
            studentData.Add(j);
            studentData.Add(k);
            studentData.Add(l);

            //Prompt the user to ask about a particular student

            Console.WriteLine("Welcome to our C# class.");
            Console.WriteLine("Which student would you like to learn more about? (enter a number 1-11 )");
            int userRequest = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You selected student number " + userRequest);

                foreach (Student s in studentData)
                {
                    int number = s.GetStudentNumber();
                    if (number == userRequest)
                    {
                        string name = s.GetStudentName();
                        string food = s.GetStudentFood();
                        string hometown = s.GetStudentHometown();
                        Console.WriteLine("Student number " + number + " is " + name);
                        Console.WriteLine("Would you like to know " + name + "'s favorite food or hometown?");
                        string askInfo = Console.ReadLine();
                        if (askInfo == "food")
                            Console.WriteLine(name + "'s favorite food is " + food);
                        else if (askInfo == "hometown")
                            Console.WriteLine(name + "'s home town is " + hometown);
                        else
                            Console.WriteLine(askInfo + " is not a valid option. Please try again.");
                        break;
                    }
                }
                run = Continue();

            }

        }
        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
                //SquaresAndCubes();
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                //So this is a neat trick call recursion, it involves calling a method inside a method
                //In a sense it's another way of doing a loop, but using methods 
                //it works in much the same way, it's divided into two parts: 
                //a step and an end condition. 
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }

    
    }

}