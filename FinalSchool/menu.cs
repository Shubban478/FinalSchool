using System;
namespace FinalSchool
{
    public class Menu
    {
        public void PreText()
        {
            Console.WriteLine("You have arrived at school. How did you get here?");
            Console.WriteLine("Please choose the alternative that suits your needs best.");
            Console.WriteLine("1) By car, park in the garage");
            Console.WriteLine("2) By bike, use the bicycle rack");
            Console.WriteLine("3) I walked here, i just want to go inside the school!");
        }

        public void PreMenu()
        {
            ParkingGarage carpark = new();
            BicycleGarage bikepark = new();

            Console.Clear();
            PreText();

            bool retry = false;

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        carpark.HaveParkingPass();
                        break;
                    case "2":
                        bikepark.BicycleRack();
                        break;
                    case "3":
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        retry = true;
                        break;
                }
            } while (retry != false);
        }

        public void MainText()
        {
            Console.WriteLine("Welcome to school! Are you are student or a teacher?");
            Console.WriteLine("If you are a student, please register.");
            Console.WriteLine("1) Students");
            Console.WriteLine("2) Employees");
            Console.WriteLine("3) Register as student");
            Console.WriteLine("4) Exit");
        }

        public void MainMenu()
        {
            Console.Clear();
            MainText();

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
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        retry = true;
                        break;
                }
            } while (retry != false);
        }

        public void StudentText()
        {
            Console.WriteLine("Welcome student, what do you want to do?");
            Console.WriteLine("1) Attend class");
            Console.WriteLine("2) Send homework for grading");
            Console.WriteLine("3) Get graded homework");
            Console.WriteLine("4) Back to main menu");
        }

        public void StudentMenu()
        {
            Console.Clear();
            StudentText();

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
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        retry = true;
                        break;
                }

            } while (retry != false);
        }

        public void StaffText()
        {
            Console.WriteLine("Welcome teacher, what do you want to do?");
            Console.WriteLine("1) Teach class");
            Console.WriteLine("2) Grade homework");
            Console.WriteLine("3) Attendence list");
            Console.WriteLine("4) Go to breakroom");
            Console.WriteLine("5) Back to main menu");

        }

        public void StaffMenu()
        {
            Console.Clear();
            StaffText();

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
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        retry = true;
                        break;
                }

            } while (retry != false);
        }

        public void Quit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for attending school today! Press any key to exit and see you soon!");
            Console.WriteLine("PS. Don't forget to do your homework!!");
            Console.ReadKey();
        }
    }
}
