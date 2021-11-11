using System;
using System.Collections.Generic;

namespace FinalSchool
{
    public class Humans
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string Zipcode  { get; set; }
    }

    public class Staff : Humans
    {
        public static List<string> students = new();

        public void AttendenceList()
        {
            Console.Clear();
            Console.WriteLine("All students attending class today:\r\n");
            foreach (var item in students)
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
        public void AttendClass()
        {
            Classroom classroom = new();
            Canteen canteen = new();
            Menu menu = new();

            Console.Clear();
            Console.WriteLine("You attend class. What do you want to do now?\r\n");
            Console.WriteLine("1) Read a book");
            Console.WriteLine("2) Eat lunch");
            Console.WriteLine("3) Back to menu");

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
                        menu.StudentMenu();
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
            Menu menu = new();
            menu.StudentMenu();
        }

        public void GetGradedHomework()
        {
            Console.Clear();
            Console.WriteLine("Good job! You got an A!");
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
            Menu menu = new();
            menu.StudentMenu();
        }

        public string GetValidName()
        {
            Console.WriteLine("Let's get you registered!");
            Console.WriteLine("Enter your full name: ");

            string input = "";
            bool validString = false;
            while (validString != true)
            {
                input = Console.ReadLine();

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

        public string GetValidStreet()
        {
            Console.WriteLine("Alright! Thank you for your information. Almost finished! Enter your streetname: ");

            string input = "";
            bool validStreet = false;
            while (validStreet != true)
            {
                input = Console.ReadLine();

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

            string input = "";
            bool validCity = false;
            while (validCity != true)
            {
                input = Console.ReadLine();

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

            string input = "";
            bool validZip = false;
            while (validZip != true)
            {
                input = Console.ReadLine();

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
            Staff.students.Add(GetValidName());
            GetValidDate();
            Staff.students.Add(GetValidStreet());
            Staff.students.Add(GetValidCity());
            Staff.students.Add(GetValidZip());
            Console.WriteLine("Great, press any key to return to main menu");
            Console.ReadKey();
            Menu menu = new();
            menu.MainMenu();
        }
    }
}
