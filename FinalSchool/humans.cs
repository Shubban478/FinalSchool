using System;
using System.Collections.Generic;

namespace FinalSchool
{
    public class Humans
    {
        string fullName;

        int age;

        string streetAddress;

        string city;

        string zipcode;
    }

    public class Staff : Humans
    {
        public void AttendenceList()
        {

        }

        public void TeachClass()
        {
            Console.Clear();
            Console.WriteLine("You have teached your class. Good job!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }

        public void GradeHomework()
        {
            Console.Clear();
            Console.WriteLine("You have graded all homework. Good job!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }

        public void DrinkCoffee()
        {
            Console.Clear();
            Console.WriteLine("Mmmhmm... Best time of the day!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }

    public class Students : Humans
    {
        readonly List<string> students = new();

        public void AttendClass()
        {
            Console.Clear();
            Console.WriteLine("You attend class. What do you want to do?");
            Console.WriteLine("1) Read a book");
            Console.WriteLine("2) Eat lunch");
            Console.WriteLine("3) Back to menu\r\n");

            bool retry = false;

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("\r\nNot a valid choice.");
                        retry = true;
                        break;
                }
            } while (retry != false);
        }

        public void SendHomework()
        {
            Console.Clear();
            Console.WriteLine("You sent your homework. Good job!");
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
        }

        public void GetGradedHomework()
        {
            Console.Clear();
            Console.WriteLine("Good job! You got an A!");
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
        }

        public string GetValidString()
        {
            Console.WriteLine("Let's get you registered!");
            Console.WriteLine("Enter your full name: ");

            bool validString = false;
            string input = Console.ReadLine();
            while (validString != true)
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validString = false;
                }
                else
                {
                    validString = true;
                }
            }

            return input;
        }

        public DateTime GetValidDate()
        {
            Console.WriteLine("Welcome to our school! \r\n" + "To continue, enter your date of birth: YYYY-MM-DD");

            bool validDate = false;
            DateTime input = Convert.ToDateTime(Console.ReadLine());
            while (validDate != true)
            {
                try
                {
                    DateTime socialSecurityNumber = Convert.ToDateTime(Console.ReadLine());
                    validDate = true;
                }
                catch
                {
                    Console.WriteLine("Not a valid format. Try again");
                    validDate = false;
                }
            }

            return input;
        }

        public string GetValidStreet()
        {
            Console.WriteLine("Alright! Thank you for your information. Almost finished! Enter your streetname: ");

            bool validStreet = false;
            string input = Console.ReadLine();
            while (validStreet != true)
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validStreet = false;
                }
                else
                {
                    validStreet = true;
                }
            }

            return input;
        }

        public string GetValidCity()
        {
            Console.WriteLine("And the name of your city?");

            bool validCity = false;
            string input = Console.ReadLine();
            while (validCity != true)
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validCity = false;
                }
                else
                {
                    validCity = true;
                }
            }

            return input;
        }

        public string GetValidZip()
        {
            Console.WriteLine("Last but not least your zipcode!");

            bool validZip = false;
            string input = Console.ReadLine();
            while (validZip != true)
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validZip = false;
                }
                else
                {
                    validZip = true;
                }
            }

            return input;
        }

        public void Register()
        {
            Console.Clear();
            GetValidString();
            GetValidDate();
            GetValidStreet();
            GetValidCity();
            GetValidZip();
            Console.WriteLine("Great, press any key to return to main menu");
            Console.ReadKey();
        }
    }
}
