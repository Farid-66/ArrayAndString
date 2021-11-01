using System;
using System.Linq;
namespace ArrayandString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            int[] arr = { 7, 8, 3, 7, 4, 7, 7, 5};
            Console.WriteLine(Duplicate(arr));

            #endregion

            #region Task2

            //int[] arr = { 7, 8, 3, 7, 4, 3, 7, 5 };
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(FindEquals(arr,num));

            #endregion

            #region Task3

            //int[] arr = new int[10] { 7, 8, 3, 7, 4, 3, 5, 2, 4, 10 };
            //Console.WriteLine(ReverseArray(arr));

            #endregion

            #region Task4

            //int[] arr1 = new int[5] { 5, 2, 1, 3, 9 };
            //int[] arr2 = new int[5] { 4, 8, 10, 6, 12 };
            //Console.WriteLine(Concatenate(arr1, arr2));


            #endregion

            #region Task5

            //int[] arr = { 5, 1, 3, 9, 2, 0, 3, 11, 19, -5 };
            //MaxAndMin(arr);

            #endregion

            #region Task6

            //int[] arr = { 2, 5, 6, 7, 12, 16, 3, 9 };
            //EvenAndOdd(arr);

            #endregion

            #region Task7

            //string text = "Contrary to popular belief, Lorem Ipsum is not simply random ature from 45 BC," +
            //    " making it over 2000 years old. Richard";
            //Substring(text);

            #endregion

            #region Task8

            //string text = Console.ReadLine();
            //InputString(text);

            #endregion

            #region Task9

            //string text = "hello World";
            //Console.WriteLine(StringLength(text));

            #endregion

            #region Task10

            //string text = "hello World";
            //Console.WriteLine(ReverseString(text));

            #endregion

            #region Task11

            //string text = "hello The World the hello the World hello the World ";
            //Console.WriteLine(TheCount(text));

            #endregion
        }

        #region Task1 Method

        static int Duplicate(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1; j < arr.Length; j++) 
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                
            }
            return count;
        }

        #endregion

        #region Task2 Method

        static bool FindEquals(int[] arr, int num)
        {
            foreach (int item in arr)
            {
                if (item == num)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Task3 Method

        static string ReverseArray(int[] arr)
        {
            string str = "";
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                str = str + " " + i;
            }
            return str;

        }

        #endregion

        #region Task4 Method

        static string Concatenate(int[] arr1, int[] arr2)
        {
            string str = "";
            int[] newarr = arr1.Concat(arr2).ToArray();
            Array.Sort(newarr);
            foreach (int i in newarr)
            {
                str = str + " " + i;
            }
            return str;
        }

        #endregion

        #region Task5 Method

        static void MaxAndMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }

        #endregion

        #region Task6 Method

        static void EvenAndOdd(int[] arr)
        {
            string even = "";
            string odd = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    /*Array.Resize(ref evenarray, evenarray.Length + 1);
                    evenarray[evenarray.Length - 1] = arr[i];

                    for (int j = 0; j < evenarray.Length; j++)
                    {
                        return evenarray;
                    }*/

                    even = even + " " + arr[i];
                }
                else
                {
                    /*Array.Resize(ref oddarray, oddarray.Length + 1);
                    oddarray[oddarray.Length - 1] = arr[i];

                    for (int k = 0; k < oddarray.Length; k++)
                    {
                        return oddarray;
                    }*/

                    odd = odd + " " + arr[i];
                }
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }

        #endregion

        #region Task7 Method

        static void Substring(string text)
        {
            if (text.Length > 50)
            {
                Console.WriteLine(text.Substring(0, 50) + "...");
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        #endregion

        #region Task8 Method

        static void InputString(string input)
        {
            Console.WriteLine(input);
        }

        #endregion

        #region Task9 Method

        static void StringLength(string input)
        {
            Console.WriteLine(input.Length);
        }

        #endregion

        #region Task10 Method

        static string ReverseString(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        #endregion


        #region Task11 Method

        static int TheCount(string str)
        {
            int count = 0;
            string[] str1 = str.Split(' ');
            foreach (string str2 in str1)
            {
                if (str2 == "The" || str2 == "the")
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

    }
}
