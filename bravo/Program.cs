using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bravo
{
    internal class Program
    {
        static readonly List<string> staff = new List<string>();

        public static List<string> Staff => staff;

        static void Main(string[] args)
        {
            int Option;
            Console.WriteLine("==========Employee Information==========");

            do
            {
                Console.WriteLine("enter a number for one of the following options:");

                Console.WriteLine("1. Add Information");
                Console.WriteLine("2. Insert Information");
                Console.WriteLine("3. Update Information");
                Console.WriteLine("4. Delete Information");
                Console.WriteLine("5. Search Information");
                Console.WriteLine("6. Display Information");
                Console.WriteLine("0. to end this program ");
                Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        Console.WriteLine("You have selected option 1 to Add data into file");
                        AddName();
                        break;
                    case 2:
                        Console.WriteLine("You have selected option 2 to insert information in the file");
                        InsertName();
                        break;
                    case 3:
                        Console.WriteLine("You have selected option 3 to update information in the file");
                        break;
                    case 4:
                        Console.WriteLine("You have selected option 4 to delete data from file");
                        break;
                    case 5:
                        Console.WriteLine("You have selected option 5 to search data from file");
                        break;
                    case 6:
                        Console.WriteLine("You have selected option 6 to display Information from file");
                        break;
                    case 0:
                        Console.WriteLine("Appreciation for use of my work");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Does not exist, Please select the correct option");
                        break;

                }
            } while (Option != 0);

        }

        static void AddName()
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            staff.Add(firstName + lastName);
            Console.ReadKey();

        }
        static void InsertName()
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            int loc = Convert.ToInt32(Console.ReadLine());
            if (loc > staff.Count)
            {
                Console.WriteLine("Location out of range");

            }
            else
            {
                staff.Insert(loc, firstName + lastName);
            }
            Console.ReadKey();
        }
    }
}


