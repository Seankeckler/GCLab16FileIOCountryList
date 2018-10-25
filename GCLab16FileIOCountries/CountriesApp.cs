using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GCLab16FileIOCountries
{
    class CountriesApp
    {
        
        

        //variables
        
        //properties => get; set;
       
        //constructor

        //methods
        public static void MainMenu()
        {
            bool run;
            do
            {
                Console.WriteLine("Welcome to the Countries Maintenance Application");
                Console.WriteLine("Which would you like to do?");
                Console.WriteLine("\t 1) See the List of Countries");
                Console.WriteLine("\t 2) Add a Country");
                Console.WriteLine("\t 3) Exit this Application");
                string input = Console.ReadLine();
                int.TryParse(input, out int choice);
                run = MenuChoice(choice);
            } while (run);
        }

        public static bool MenuChoice(int choice)
        {
            string path = @"C:\Users\seank\source\repos\GCLab16FileIOCountries\GCLab16FileIOCountries\countries.txt";
            FileReader Readit = new FileReader(path);

            if (choice == 1)
            {
                
                string path2 = Readit.GetAllRemainingLines();
                Console.WriteLine(path2);
                Readit.SRClose();
                return true;
            }
            else if (choice == 2)
            {
                
                Console.WriteLine("What do you want to add?");
                string addition = Console.ReadLine();
                string path2 = Readit.GetAllRemainingLines();
                Readit.SRClose();
                FileWriter Writeit = new FileWriter(path);
                Writeit.WriteToFile(path2 + "\n" + addition);
                Writeit.SWClose();
                return true;
            }
            else if (choice == 3)
            {
                Console.WriteLine("Have a good day");
                Console.ReadKey();
                return false;

            }
            //else if (choice == 4)
            //{
            //    string line = null;
            //    string line_to_delete = "the line i want to delete";
                
            //    Console.WriteLine("Which do you want to delete?");
            //    line = Console.ReadLine();
            //    string path2 = Readit.GetAllRemainingLines();
            //    Console.WriteLine(path2);
            //    Readit.SRClose();


            //    return true;
            //}
            else
            {
                Console.WriteLine("That wasnt an option");
                return true;
            }
        }



    }
}
