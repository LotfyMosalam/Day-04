namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 One D Array
            //// Examble 01 :

            //int[] numbers;
            //numbers = new int[3];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]); 


            ////// Examble 02 :

            //int[] numbers = new int[3];
            //Console.WriteLine($"The Size of Array = {numbers.Length}, Numbers of Dimensions = {numbers.Rank}");
            ////foreach (int i in numbers)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //if (numbers.Length > 3)
            //{
            //    numbers[3] = 4; 
            //}
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion


            #region Part 02 Two D Array - Rectangular

            ///uint[,] Grades = new uint[3, 5];
            ///
            ///Console.WriteLine($"The Size of Array = {Grades.Length}, Numbers of Dimensions = {Grades.Rank}");
            ///
            ///for (int r = 0; r < Grades.GetLength(0); r++)
            ///{
            ///    Console.WriteLine($"Please Insert The Grades for Student Number : ({r+1})");
            ///    for(int c = 0; c < Grades.GetLength(1);)
            ///    {
            ///        Console.Write($"The Grade for the Subject No ({c + 1}) = "); 
            ///      
            ///        c = uint.TryParse(Console.ReadLine(), out Grades[r, c]) && Grades[r, c] <= 100 ? ++c : c;
            ///    }
            ///    Console.WriteLine();
            ///}
            ///
            ///Console.Clear();

            ///for (int r = 0; r < Grades.GetLength(0); r++)
            ///{
            ///    Console.WriteLine($"These are grades for student No : {r + 1}");
            ///    for (int c = 0; c < Grades.GetLength(1); c++)
            ///    {
            ///        Console.WriteLine($"This Grade for Subject No ({c + 1}) = {Grades[r, c]}");
            ///    }
            ///    Console.WriteLine();
            ///}

            ///foreach (int grade in Grades)
            ///{
            ///    Console.WriteLine(grade);
            ///}

            ///for (int i = 0; i < Grades.Length; i++)
            ///{
            ///    Console.WriteLine(Grades[i/5, i%5]);
            ///}

            ///Grades[0, 0] = 99;
            ///Grades[0, 1] = 98;
            ///Grades[0, 2] = 92;
            ///Grades[0, 3] = 93;
            ///Grades[0, 4] = 100;
            ///
            ///Grades[1, 0] = 99;
            ///Grades[1, 1] = 98;
            ///Grades[1, 2] = 92;
            ///Grades[1, 3] = 93;
            ///Grades[1, 4] = 100;
            ///
            ///Grades[2, 0] = 99;
            ///Grades[2, 1] = 98;
            ///Grades[2, 2] = 92;
            ///Grades[2, 3] = 93;
            ///Grades[2, 4] = 100;

            #endregion


            #region Part 03 Two D Array - Judged Array

            //int[][] Marks = new int[3][];

            //Marks[0] = new int[3] { 1, 2, 3 };
            //Marks[1] = new int[2] { 4, 5 };
            //Marks[2] = new int[1] { 6 };

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.Write("Marks[" + i + "] = ");
            //    foreach (int value in Marks[i])
            //    {
            //        Console.Write(value + " ");
            //    }
            //    Console.WriteLine(); 
            //}

            #endregion


            #region Part 04 Array Methods

            #region 1.  Class Member Methods [Static Methods]

            //// Class Member Methods [Static Methods]

            //int[] Numbers = { 10, 2, 5, 6, 4, 3, 1, 5, 9, 8 };
            //int[] Array01 = { 1, 2, 3 };
            //int[] Array02 = new int[2];

            ////Array.Copy(Array01, Array02, 2);
            ////Array.Sort(Numbers);
            ////Array.Clear(Numbers);
            ////Array.ConstrainedCopy(Array01, 1, Array02, 0, 2);
            ////Array02 = (int[])Array.CreateInstance(typeof(int), 10);
            ////int[,] Array03 = (int[,])Array.CreateInstance(typeof(int), 2, 4);
            ////int[,,] Array04 = (int[,,])Array.CreateInstance(typeof(int), 2, 4, 2);

            ////int index01 = Array.IndexOf(Numbers, 5);
            ////Console.WriteLine(index01);
            ////int index02 = Array.LastIndexOf(Numbers, 5);
            ////Console.WriteLine(index02);

            ////foreach (int Number in Array04)
            ////{
            ////    Console.WriteLine(Number);
            ////} 
            #endregion


            #region 2.  Object Member Methods [Non Static Methods]

            //int[] Numbers = { 10, 2, 5, 6, 4, 3, 1, 5, 9, 8 };
            //int[] Array01 = { 1, 2, 3 };
            //int[] Array02 = new int[5];

            ////Array01.CopyTo(Array02, 1);
            ////Console.WriteLine(Array01.GetLength(0)); 
            ////Console.WriteLine(Array01.GetValue(1));
            //Array01.SetValue(100, 1);

            //foreach (int number in Array01)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #endregion


            #region Part 05 Boxing, UnBoxing

            /// Boxing
            ///
            ///object obj;
            ///obj = new object();
            ///obj = new string("Nada");
            ///obj = 5;    //Boxing
            ///obj = 5.5;  //Boxing
            ///obj = true; //Boxing
            ///obj = 'A';  //Boxing
            ///Console.WriteLine($"obj = {obj}");

            ///un Boxing
            ///object obj;
            ///obj = new object();
            ///int Number;
            ///Number = (int)obj;  //unBoxing (un safe casting)
            ///Number = obj.GetType() == typeof(int) ? (int)obj : 0; //safe
            ///Number = obj is int ? (int)obj : 0;  //syntax suger
            ///Console.WriteLine(Number);

            #endregion


            #region Part 07 Nullable - Value Types

            //Example 1

            //Nullable<int> Age;
            //int? Age; //syntax suger
            //Age = null;
            //Console.WriteLine(Age is null? 0: Age);
            //Console.WriteLine(Age.HasValue? Age: 0);

            //Example 2

            //Nullable<decimal> salary;
            //decimal? salary;
            //salary = null;
            //salary = 5_000;
            //Console.WriteLine(salary is null? 0: salary);
            //Console.WriteLine(salary.HasValue? salary: 0);

            //Example 3

            //int x = 10;             //x Allows int only
            //int? y = x;          //y Allows int + null
            //Console.WriteLine(y);
            //casting from int [value type] to Nullable<int>[Nullable value type}
            //safe castiing


            #endregion


            #region Part 08 Nullable - Reference Types  

            //string  Message01=null!;  //! null forgiveness operator
            //string? Message02=null;
            //Console.WriteLine(Message01);
            //Console.WriteLine(Message02);

            #endregion


            #region Part 09 Null Propagation Operator

            //Example 1

            //int[]? Numbers = { 1, 2, 3, 4, 5 };
            //if (Numbers is not null)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}

            //Example 2

            //int[]? Numbers = { 1, 2, 3, 4, 5 };
            //int length;
            //if (Numbers is not null)
            //    length = Numbers.Length;
            //else
            //    length = 0;

            //length = Numbers?.Length ?? 0;

            #endregion

        }
    }
}
