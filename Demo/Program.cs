namespace Demo
{
    internal class Program
    {
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

        }
    }
}
