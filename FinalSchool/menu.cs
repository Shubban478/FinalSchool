using System;
namespace FinalSchool
{
    public class Menu
    {
        public void PreText()
        {
            Console.WriteLine("You have arrived at school. How did you get here?");
            Console.WriteLine("Please choose the alternative that suits your needs best.\r\n");
            Console.WriteLine("1) By car, park in the garage");
            Console.WriteLine("2) By bike, use the bicycle rack");
            Console.WriteLine("3) I walked here, i just want to go inside the school!");
            Console.WriteLine("4) I think i feel sick, maybe i should just go home...");
        }

        public void PreMenu()
        {
            Console.Clear();
            PreText();
            bool retry = false;
            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        ParkingGarage carpark = new();
                        carpark.HaveParkingPass();
                        break;
                    case "2":
                        BicycleGarage bikepark = new();
                        bikepark.BicycleRack();
                        break;
                    case "3":
                        MainMenu();
                        break;
                    case "4":
                        QuitSick();
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
            Console.WriteLine("If you are a student, please register.\r\n");
            Console.WriteLine("1) Students");
            Console.WriteLine("2) Employees");
            Console.WriteLine("3) Register as student");
            Console.WriteLine("4) Exit");
        }

        public void MainMenu()
        {
            Students menu = new();
            Console.Clear();
            MainText();

            bool retry = false;

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        StudentMenu();
                        break;
                    case "2":
                        StaffMenu();
                        break;
                    case "3":
                        menu.Register();
                        break;
                    case "4":
                        Quit();
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
            Console.WriteLine("Welcome student, what do you want to do?\r\n");
            Console.WriteLine("1) Attend class");
            Console.WriteLine("2) Send homework for grading");
            Console.WriteLine("3) Get graded homework");
            Console.WriteLine("4) Back to main menu");
        }

        public void StudentMenu()
        {
            Students menu = new();
            Menu main = new();

            Console.Clear();
            StudentText();

            bool retry = false;

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        menu.AttendClass();
                        break;
                    case "2":
                        menu.SendHomework();
                        break;
                    case "3":
                        menu.GetGradedHomework();
                        break;
                    case "4":
                        main.MainMenu();
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
            Console.WriteLine("Welcome teacher, what do you want to do?\r\n");
            Console.WriteLine("1) Teach class");
            Console.WriteLine("2) Grade homework");
            Console.WriteLine("3) Attendence list");
            Console.WriteLine("4) Eat lunch");
            Console.WriteLine("5) Drink coffee");
            Console.WriteLine("6) Back to main menu");

        }

        public void StaffMenu()
        {
            Staff menu = new();
            StaffRoom room = new();
            Menu main = new();
            Console.Clear();
            StaffText();

            bool retry = false;

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        menu.TeachClass();
                        break;
                    case "2":
                        menu.GradeHomework();
                        break;
                    case "3":
                        menu.AttendenceList();
                        break;
                    case "4":
                        room.HeatFood();
                        break;
                    case "5":
                        menu.DrinkCoffee();
                        break;
                    case "6":
                        main.MainMenu();
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        retry = true;
                        break;
                }

            } while (retry != false);
        }

        public void QuitSick()
        {
            Console.Clear();
            Console.WriteLine("Too bad, hope you feel better soon! See you later!");
            Console.ReadKey();
        }

        public void Quit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for attending school today!");
            Console.WriteLine("Don't forget to do your homework before you play videogames tonight! ;)");
            Console.WriteLine("See you tomorrow again!");
        }
    }
}
