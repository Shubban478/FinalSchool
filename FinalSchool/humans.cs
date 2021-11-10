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
            Students list = new();

            Console.WriteLine("All students attending class today:\r\n");
            foreach (var item in list.students)
             {
                    Console.WriteLine(item);
                }

            Console.ReadKey();
            Menu menu = new();
            menu.StaffMenu();
        }

        public void TeachClass()
        {
            Console.Clear();
            Console.WriteLine("You have teached your class. Good job!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Menu menu = new();
            menu.StaffMenu();
        }

        public void GradeHomework()
        {
            Console.Clear();
            Console.WriteLine("You have graded all homework. Good job!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Menu menu = new();
            menu.StaffMenu();
        }

        public void DrinkCoffee()
        {
            Console.Clear();
            Console.WriteLine("Mmmhmm... Best time of the day!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Menu menu = new();
            menu.StaffMenu();
        }
    }

    public class Students : Humans
    {
        public List<string> students = new();

        public void AttendClass()
        {
            Classroom classroom = new();
            Canteen canteen = new();
            Menu menu = new();

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
                        classroom.Read();
                        break;
                    case "2":
                        canteen.HaveLunch();
                        break;
                    case "3":
                        menu.MainMenu();
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

        public void GetValidName()
        {
            Console.WriteLine("Let's get you registered!");
            Console.WriteLine("Enter your full name: ");

            bool validString = false;
            while (validString != true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validString = false;
                }
                else
                {
                    students.Add(input);
                    validString = true;
                }
            }
        }

        public void GetValidDate()
        {
            Console.WriteLine("Welcome to our school! \r\n" + "To continue, enter your date of birth: YYYY-MM-DD");

            bool validDate = false;

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
        }

        public void GetValidStreet()
        {
            Console.WriteLine("Alright! Thank you for your information. Almost finished! Enter your streetname: ");

            bool validStreet = false;
            while (validStreet != true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validStreet = false;
                }
                else
                {
                    students.Add(input);
                    validStreet = true;
                }
            }
        }

        public void GetValidCity()
        {
            Console.WriteLine("And the name of your city?");

            bool validCity = false;

            while (validCity != true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validCity = false;
                }
                else
                {
                    students.Add(input);
                    validCity = true;
                }
            }
        }

        public void GetValidZip()
        {
            Console.WriteLine("Last but not least your zipcode!");

            bool validZip = false;

            while (validZip != true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid input.");
                    validZip = false;
                }
                else
                {
                    students.Add(input);
                    validZip = true;
                }
            }
        }

        public void Register()
        {
            Console.Clear();
            GetValidName();
            GetValidDate();
            GetValidStreet();
            GetValidCity();
            GetValidZip();
            Console.WriteLine("Great, press any key to return to main menu");
            Console.ReadKey();
            Menu menu = new();
            menu.MainMenu();
        }
    }
}
