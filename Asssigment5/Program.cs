using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Asssigment5
{

    #region Q01
    //enum WeekDays
    //{

    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}
    #endregion

    #region Q02
    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter

    //}
    #endregion

    #region Q03
    //[Flags]
    //enum Permissions
    //{
    //    Read = 0,
    //    Write = 1,
    //    Delete = 2,
    //    Execute = 4
    //} 
    #endregion

    #region Q04
    //enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue

    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Create an enum called "WeekDays" with the days of the week(Monday to Sunday) 
            //as its members.Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (WeekDays days   in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(days);
            //}

            #endregion

            #region Q02
            //Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a
            //    C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //    Note range for seasons 
            //    ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter the Number Or Name Of Season");
            //Season season = (Season)Enum.Parse(typeof(Season), Console.ReadLine(), true);
            //try
            //{


            //    switch (season)

            //    {
            //        case Season.Spring:
            //            Console.WriteLine("spring march to may");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("summer june to august");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("winter December to February");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("autumn September to November");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season");
            //            break;
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid Invalid input. Please enter a valid season name");
            //}

            #endregion

            #region Q03
            //Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permissions P01 = Permissions.Write;
            //P01 |= Permissions.Read;
            //Console.WriteLine(P01);
            //if (P01.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("Read permission is granted.");

            //}
            //if (P01.HasFlag(Permissions.Delete))
            //{
            //    Console.WriteLine("Delete permission ");
            //}
            //else
            //{
            //    Console.WriteLine("Delete permission is not ");
            //}
            //P01 &= ~(Permissions.Write);

            //P01 |= Permissions.Execute;

            //Console.WriteLine(P01);
            #endregion

            #region Q04
            //Create an enum called "Colors" with the basic colors(Red, Green, Blue) as 
            //its members.Write a C# program that takes a color name as input from the
            //    user and displays a message indicating whether the input color is a primary color or not.


            //Console.WriteLine("Enter a color name");
            //string ColerInput = Console.ReadLine();
            //try
            //{
            //    Colors color = (Colors)Enum.Parse(typeof(Colors), ColerInput, true);
            //    Console.WriteLine("is a primary color");
            //}
            //catch (Exception ex)
            //{
            //    {
            //        Console.WriteLine("input color is a primary color or not");
            //        Console.WriteLine(ex.Message);
            //    }
            //    #endregion

            //
            //}
        }
    }
}

