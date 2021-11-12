using System;
using System.Collections.Generic;

namespace FinalSchool
{
    public class Humans
    {
        protected string FullName { get; set; }

        protected string Age { get; set; }

        protected string StreetAddress { get; set; }

        protected string City { get; set; }

        protected string Zipcode  { get; set; }
    }

    public class Staff : Humans
    {
        public static readonly List<string> students = new();

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
                        Classroom classroom = new();
                        classroom.Read();
                        break;
                    case "2":
                        Canteen canteen = new();
                        canteen.HaveLunch();
                        break;
                    case "3":
                        Menu menu = new();
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
            bool validString = false;
            while (validString != true)
            {
                FullName = Console.ReadLine();
                if (String.IsNullOrEmpty(FullName))
                {
                    Console.WriteLine("Not a valid input.");
                    validString = false;
                }
                else
                {
                    validString = true;
                }
            }

            return FullName;
        }

        public string GetValidDate()
        {
            Console.WriteLine("\r\nWelcome to our school! \r\n" + "To continue, enter your date of birth: YYYY-MM-DD");
            bool validDate = false;

            while (validDate != true)
            {
                try
                {
                    DateTime socialSecurityNumber = Convert.ToDateTime(Console.ReadLine());
                    Age = Convert.ToString(socialSecurityNumber);
                    validDate = true;
                }
                catch
                {
                    Console.WriteLine("\r\nNot a valid format. Try again");
                    validDate = false;
                }
            }

            return Age;
        }

        public string GetValidStreet()
        {
            Console.WriteLine("\r\nAlright! Thank you for your information. Almost finished! Enter your streetname: ");
            bool validStreet = false;
            while (validStreet != true)
            {
               StreetAddress = Console.ReadLine();
               if (String.IsNullOrEmpty(StreetAddress))
               {
                   Console.WriteLine("\r\nNot a valid input.");
                   validStreet = false;
               }
               else
               {
                   validStreet = true;
               }
            }

            return StreetAddress;
        }

        public string GetValidCity()
        {
            Console.WriteLine("\r\nAnd the name of your city?");
            bool validCity = false;
            while (validCity != true)
            {
                City = Console.ReadLine();
                if (String.IsNullOrEmpty(City))
                {
                    Console.WriteLine("\r\nNot a valid input.");
                    validCity = false;
                }
                else
                {
                    validCity = true;
                }
            }

            return City;
        }

        public string GetValidZip()
        {
            Console.WriteLine("\r\nLast but not least your zipcode!");
            bool validZip = false;
            while (validZip != true)
            {
                Zipcode = Console.ReadLine();

                if (String.IsNullOrEmpty(Zipcode))
                {
                    Console.WriteLine("\r\nNot a valid input.");
                    validZip = false;
                }
                else
                {
                    validZip = true;
                }
            }
            return Zipcode;
        }

        public void Register()
        {
            Console.Clear();
            Staff.students.Add(GetValidName());
            Staff.students.Add(GetValidDate());
            Staff.students.Add(GetValidStreet());
            Staff.students.Add(GetValidCity());
            Staff.students.Add(GetValidZip() + "\r\n");
            Console.WriteLine("\r\nGreat, press any key to return to main menu");
            Console.ReadKey();
            Menu menu = new();
            menu.MainMenu();
        }
    }
}