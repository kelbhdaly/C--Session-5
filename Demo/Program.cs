using System;
using System.Security.AccessControl;

namespace Demo
{

    enum Season
    {
        Spring,
        Winter,
        Summer,
        Autumn
    }
    enum WeekDay
    {
        Saturday,
        SunDay,
        MonDay,

    }
    enum Gender
    {
        Male,
        Female
    }


    // Read , Write , Execute , Delete
    [Flags]
    enum Permissions
    {
        Read =8, 
        Write =4,
        Execute =2,
        Delete =1
    }
    internal class Program
    {

        ////static void DoSomeCode()
        ////{
        ////    int X, Y, Z;
        ////     X = int.Parse(Console.ReadLine());

        ////    Y = int.Parse(Console.ReadLine());

        ////    Z = X / Y;

        ////    int[] Arr = { 1, 2, 3 };

        ////    Arr[99] = 10; //Out Of Range
        ////}
        
        //static void DoSomeCode()
        //{

        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine());

        //        Y = int.Parse(Console.ReadLine());

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3 };

        //        Arr[99] = 10; //Out Of Range
        //    }
        //    catch (Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally");
        //    }
        //}

        //static void DoSomeProtectiveCode()
        //{
        // try
        //    {

        //        int X, Y, Z;

        //        bool Flag;
        //        do
        //        {
        //            Console.Write("enter the First number : ");
        //            Flag = int.TryParse(Console.ReadLine(), out X);
        //        } while (Flag == false);

        //        do
        //        {
        //            Console.Write("enter the First number : ");
        //            Flag = int.TryParse(Console.ReadLine(), out Y);
        //        } while (Flag == false && Y != 0);

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3, 4 };
        //        if (99 < Arr?.Length)
        //        {
        //            Arr[99] = 10;
        //        }
        //    }
        //    catch(Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }

        //}


        static void test()
        {
            try
            {
                int Num01, Num02, Divid;
                bool Flag;
                do
                {
                    Console.WriteLine("Enter the Fisrt Number : = ");
                    Flag = int.TryParse(Console.ReadLine(), out Num01);
                } while (Flag == false);

                do
                {
                    Console.WriteLine("Enter the Fisrt Number : = ");
                    Flag = int.TryParse(Console.ReadLine(), out Num02);
                } while (Flag == false && Num02 != 0);

                Divid = Num01 / Num02;
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }

           
        }
        static void Main(string[] args)
        {
            #region Boxing&UnBoxing
            //Boxing : Casting From Value Type To References Value 
            //UnBoxing : Casting From References Type To References Value Type

            //object O1;
            ////O1 => Refer To Instance Of 'Object' Or Any Instance Of Any Type 
            ////O1 = "khaled";
            ////O1 = 10;
            ////O1 = 3; 
            //int Num = 5;
            //O1 =(object) Num; //Boxing Impliced Casting Safe


            //object O1 = 3;
            //int Num = (int) O1; 
            //UnBoxing
            //Explicit Casting
            // UnSafe Casting [May Throw Exception]

            #endregion


            #region Nullable Value

            //Nullable Type 
            //Value Type 
            //Reference Type

            //int Num = 5;
            //Num = null; //Invalid
            //Nullable <int>: Allow Null
            //int? Num = 5;
            //Num = null;

            //double? Salary = 4000.5;
            //Salary = null;

            //int x = 5;
            //int? y = x;


            //int? x;
            //x = null;

            //int y;

            //UnBoxing 
            //May Throw Exeption


            //Defensive Code
            //if(x != null)
            //{
            //    y = (int)x;

            //}
            //else
            //{
            //    y = 0;
            //}

            //==============================
            //if (x is not null)
            //{
            //    y = (int)x;

            //}
            //else
            //{
            //    y = 0;
            //}

            //if (x.HasValue)
            //    y = x.Value;
            //else
            //    y = 0;
            //y = x.HasValue ? x.Value : 0;
            //y = x is not null ? x.Value : 0;

            //===========================

            /*y = x ?? 0; *///Syntax Sugar :x is not null ? x.Value : 0; 




            //int Num = 5;
            //int? Num2;
            //Num2 = Num;

            //int? Num = 5;
            //int Num2 =(int) Num; //UnBoxing


            //int? Num;
            //Num = null;
            //int Num2;
            //if(Num is not null)
            //{
            //    Num2 = (int)Num;
            //}
            //else
            //{
            //    Num2 = 0;
            //}
            //Console.WriteLine(Num2);
            #endregion


            #region Nullable References Type
            ////Nullable Reference
            //string Message01 = null;
            //string? Message02 = null;
            //Console.WriteLine(Message01.Length);
            //Console.WriteLine(Message02); 
            #endregion

            #region Null propagation Operator

            ////Null propagation Operator ?
            //double x = default;
            //Console.WriteLine(x);

            //char C = default;
            //Console.WriteLine(C);

            ////int[] arr = default;

            //int [] arr = { 1,2,3,4};

            ////Best Rractice 
            ////if (arr is not null)
            ////{
            ////    for (int i = 0; i < arr.Length; i++) //NullReferenceException
            ////    {
            ////        Console.WriteLine(arr[i]);
            ////    }

            ////}

            ////for (int i = 0; (arr != null) && i < arr.Length; i++) //NullReferenceException
            ////{
            ////    Console.WriteLine(arr[i]);
            ////}



            ////for (int i = 0;  i < arr?.Length; i++) //NullReferenceException
            ////{
            ////    Console.WriteLine(arr[i]);
            ////} 
            #endregion


            //Exception Handling Protective Code
            //DoSomeCode();


            //Common.TypeA typeA = new TypeA(); //internal => Invalid
            /* Common.TypeB typeB = new Common.TypeB();*/ //valid 

            //Enum : Value Type
            // Stack 
            //Season S01 = Season.Autumn;

            //Gender G01 = Gender.Female;
            //Gender G02 =(Gender) 10;
            //Console.WriteLine(G02);

            //Gender G01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(),true);

            //Console.WriteLine(G01);
            Permissions permissions01 = Permissions.Read;
            permissions01 ^= Permissions.Write; //if not found will be add else remove
            Console.WriteLine(permissions01);
            permissions01 |= Permissions.Delete; //add
            permissions01 &= ~(Permissions.Delete);
            Console.WriteLine(permissions01);
        }
    }
}
