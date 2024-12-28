
using System.ComponentModel;
using System.ComponentModel.Design;

namespace oop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.


            //foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(days);


            //}
            #endregion

            #region 2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //bool isParsed;
            //Season season;
            //do
            //{
            //    Console.Write("please enter a season ");
            //    isParsed = Enum.TryParse(Console.ReadLine(), out season);
            //} while (!isParsed);
            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season.");
            //        break;
            //}
            #endregion
            #region 3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum .Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
            //Permissions permission = new Permissions();
            //permission |= Permissions.Read;
            //permission |= Permissions.Write;
            //permission |= Permissions.Delete;
            //permission |= Permissions.Execute;
            //Console.WriteLine(permission);

            //permission ^= Permissions.Delete;
            //Console.WriteLine(permission);
            //if ((permission & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("user has delete permission");
            //}
            //else
            //    Console.WriteLine("user hasn''t delete permission");
            #endregion
            #region 4-Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            // Colors color;
            // bool isParsed;
            // Console.Write("please enter a color ");
            //isParsed = Enum.TryParse( Console.ReadLine() , out color);
            // if (isParsed)
            // {
            //     Console.WriteLine($"the {color} is a primary  color : ");
            // }
            // else
            //     Console.WriteLine($"this color isn''t a primary  color ");
            #endregion
        }


    }

    }

