﻿using System;
using System.Collections.Generic;

namespace FinalSchool
{
    public class Classroom
    {
        readonly List<string> bookcase = new() { "Of Mouse And Men", "Harry Potter Collection", "The Hunger Games", "Divergent", "Basic Programing Vol. 1", "Basic Programing Vol. 2", "Git Gud In Excel" };

        public void Read()
        {
            Console.Clear();
            Console.WriteLine("There are books in here: \r\n");
            BookList();
            Console.WriteLine("Press any key for classroom menu...");
            Console.ReadKey();
            Students menu = new();
            menu.AttendClass();
            
        }

        public void BookList()
        {
            foreach (string book in bookcase)
            {
                Console.WriteLine(book);
            }

            bool retry = false;

            do
            {
                Console.WriteLine("Wich one do you want to read? Type the name of the book in lowercase\r\n");

                switch (Console.ReadLine())
                {
                    case "of mouse and men":
                        Console.WriteLine("You read Of Mouse And Men. What a great story!");
                        break;
                    case "harry potter collection":
                        Console.WriteLine("You read Harry Potter Collection. It's very long, so you have to finish it another time.");
                        break;
                    case "the hunger games":
                        Console.WriteLine("You read The Hunger Games. I wonder how it will end!");
                        break;
                    case "divergent":
                        Console.WriteLine("You read Divirgent. Though you did not like it very much and did not finish it.");
                        break;
                    case "basic programing vol. 1":
                        Console.WriteLine("You read Basic Programing Vol. 1. You learned a lot of new things! Nice!");
                        break;
                    case "basic programing vol. 2":
                        Console.WriteLine("You read Basic Programing Vol. 2. It was too complex for you. Maybe you should read vol. 1.");
                        break;
                    case "git gud in excel":
                        Console.WriteLine("You read Git Gud In Excel. You are now a master at Excel! Great job!");
                        break;
                    default:
                        Console.WriteLine("\r\nHmm i can't find this book. Maybe there is another book i can read?");
                        retry = true;
                        break;
                }

            } while (retry != false);

            Console.WriteLine("\r\nYour brain hurts and you don't feel like reading anymore.");
            Console.ReadKey();
            Students menu = new();
            menu.AttendClass();
        }
    }

    public class ParkingGarage
    {
        public bool parkingPass = false;

        public void HaveParkingPass()
        {
            Console.Clear();

            if (parkingPass != true)
            {
                Console.WriteLine("You don't own a parking pass.");
                Console.WriteLine("Do you wish to buy a parking pass? Please type y/n to make choice.");
                Console.WriteLine("Beware that you will return to the menu if you choose not to buy a parking pass.");

                bool retry = false;

                do
                {
                    switch (Console.ReadLine())
                    {
                        case "y":
                            UnlockGate();
                            break;
                        case "n":
                            Menu menu = new();
                            menu.PreMenu();
                            break;
                        default:
                            Console.WriteLine("Not a valid choice.");
                            retry = true;
                            break;
                    }
                } while (retry != false);
            }

            else
            {
                parkingPass = true;
                Console.WriteLine("You have a valid parking pass.");
                Console.WriteLine("Press any key to unlock the gate!");
                Console.ReadKey();
                UnlockGate();
            }
        }

        public void UnlockGate()
        {
            Console.Clear();
            Console.WriteLine("The gate opened and you parked your car.");
            Console.WriteLine("You walk to the enterence. Press any key to enter!");
            Console.ReadKey();
            Menu menu = new();
            menu.MainMenu();
            
        }
    }

    public class BicycleGarage
    {
        public void BicycleRack()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Lock bike");
            Console.WriteLine("2) Unlock bike");
            Console.WriteLine("3) Return to previous menu");

            bool retry = false;

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        LockBicycle();
                        break;
                    case "2":
                        UnlockBicycle();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        retry = true;
                        break;
                }
            } while (retry != false);
        }

        public void LockBicycle()
        {
            Console.Clear();
            Console.WriteLine("You locked your bike.");
            Console.WriteLine("Press any key to go inside the school!");
            Console.ReadKey();
            Menu menu = new();
            menu.MainMenu();
        }

        public void UnlockBicycle()
        {
            Console.Clear();
            Console.WriteLine("You unlocked your bike and went home.");
            Console.WriteLine("Press any key to exit program!");
            Console.ReadKey();
        }
    }

    public class StaffRoom
    {
        public void HeatFood()
        {
            Console.Clear();
            Console.WriteLine("You took out your food from the fridge and put in the microwave.");
            Console.WriteLine("The microwave goes: Bzzzzzt... Pling!");
            Console.ReadKey();
            Menu menu = new();
            menu.StaffMenu();

        }
    }

    public class Canteen
    {
        public void HaveLunch()
        {
            Console.Clear();
            Console.WriteLine("You have lunch! Yummy...");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Students menu = new();
            menu.AttendClass();
        }
    }
}
