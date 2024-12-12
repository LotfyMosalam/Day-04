namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-   Write a program that prints an identity matrix using for loop,in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter the size of the identity matrix (n): ");
            //if (int.TryParse(Console.ReadLine(), out int Number) && Number > 0)
            //{
            //    Console.WriteLine("identity table of size:");
            //    for (int r = 0; r < Number; r++)
            //    {
            //        for (int c = 0; c < Number; c++)
            //        {
            //            if (r == c)
            //                Console.Write("1");
            //            else
            //                Console.Write("0");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion


            #region 2-   Write a program in C# Sharp to find the sum of all elements of the array

            //int[] array = { 80, 93, 85, 89, 97, 81 };
            //int sum = 0;
            //foreach (int num in array)
            //{
            //    sum += num;
            //}
            //Console.WriteLine($"The sum of all elements in the array is: {sum}");

            #endregion


            #region 3-   Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr01 = { 10, 3, 6, 7, 8 };
            //int[] arr02 = { 1, 4, 5, 9, 2 };
            //int[] mergedArr03= new int[arr01.Length + arr02.Length];
            //arr01.CopyTo(mergedArr03, 0); 
            //arr02.CopyTo(mergedArr03, arr01.Length);
            //Array.Sort(mergedArr03);
            //Console.WriteLine("array :");
            //foreach (int num in mergedArr03)
            //{
            //    Console.Write(num+" - ");
            //}
            #endregion


            #region 4-   Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] array = { 5, 2, 5, 1, 7, 3, 2, 8, 7, 4, 5, 9, 1, 6, 9, 3 };
            //Console.WriteLine("Frequency of each element:");
            //for (int r = 0; r < array.Length; r++)
            //{
            //    int count = 1;
            //    if (array[r] == -1)
            //        continue;
            //    for (int c = r + 1; c < array.Length; c++)
            //    {
            //        if (array[r] == array[c])
            //        {
            //            count++;
            //            array[c] = -1;
            //        }
            //    }
            //    Console.WriteLine($"Element {array[r]} appears {count} time(s)");
            //}
            #endregion


            #region 5-   Write a program in C# Sharp to find maximum and minimum element in an array.

            //int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max = array[0];
            //int min = array[0];
            //foreach (int num in array)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine($"The maximum of element is: {max}");
            //Console.WriteLine($"The minimum of element is: {min}");

            #endregion


            #region 6-   Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 30, 24, 59, 25, 16, 77 };
            //Array.Sort(arr);
            //int secondLargest = arr[arr.Length - 2];
            //Console.WriteLine("The second largest element in an array is: " + secondLargest);

            #endregion


            #region 7-   Consider an Array of Integer values with size N, having values as    


            //Console.WriteLine("Enter the array values separated by spaces:");
            //string input = Console.ReadLine();

            //int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

            //Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            //int maxDistance = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (firstOccurrence.ContainsKey(array[i]))
            //    {
            //        int distance = i - firstOccurrence[array[i]];
            //        maxDistance = Math.Max(maxDistance, distance);
            //    }
            //    else
            //    {
            //        firstOccurrence[array[i]] = i;
            //    }
            //}

            //Console.WriteLine("The longest distance between two equal cells is: "

            #endregion


            #region 8-   Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter a sentence with space-separated words:");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));

            #endregion


            #region 9-   Write a program to create two multidimensional arrays of same size.
            //int[,] array01 = new int[2, 3];
            //int[,] array02 = new int[2, 3];
            //Console.WriteLine("Enter elements for the first array : ");
            //for (int r = 0; r < 2; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        Console.Write($"Enter element the position ({r},{c}): ");
            //        array01[r, c] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Array.Copy(array01, array02, array01.Length);
            //Console.WriteLine("The second array is : ");
            //for (int r = 0; r < 2; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        Console.Write(array02[r, c] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 10-  Write a Program to Print One Dimensional Array in Reverse Order.

            //int[] arr = new int[5];
            //Console.WriteLine("Please enter 5 numbers:");
            //for (int r = 0; r < arr.Length; r++)
            //{
            //    arr[r] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Dimensional Array in Reverse Order are :");
            //for (int r = arr.Length - 1; r >= 0; r--)
            //{
            //    Console.Write(arr[r] + " ");
            //}

            #endregion


        }
    }
}
