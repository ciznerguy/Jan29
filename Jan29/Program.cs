using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Jan29
{
    internal class Program
    {
        public static int SumOfThree(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        public static int Adg(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
        public static int [] BuildArr (int num)
            {
            Random random = new Random();
            int[] ArrToReturn= new int[num];
            for(int i = 0;i < num;i++)
            {
                ArrToReturn[i] = random.Next(-100, 101);
            }
            return ArrToReturn;
            }
        public static int[] OnlyPositive(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }
            int[] arrToReturn = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    arrToReturn[index] = arr[i];
                    index++;
                }

            }
            return arrToReturn;
        }
        public static void PrintArr (int[] arr)
        {
            for(int i = 0; i <arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }

        public static void PrintArr2(int[] arr)
        {
            foreach (int num in  arr)
            {
                Console.Write(num+",");
            }
            Console.WriteLine(  );
        }
        public static int CountInArr (int num, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
            return count;
        }
        public static bool TwiceInArr(int[] arr)
        {
            for(int i = 0;i < arr.Length; i++)
            {
                if (CountInArr(arr[i], arr)>1)
                {
                    return true;
                }
            }
            return false;
        }

        public static string LongestName (string[] names)
        {
            string maxName = names[0];
            for(int i = 1; i < names.Length; i++)
            {
                if (names[i].Length > maxName.Length)
                {
                    maxName = names[i];
                }
            }
            return maxName;
        }
        public static bool IsInArray(int[]arr1, int[] arr2)
        {
            for(int i = 0; i < arr1.Length; i++)
            {
                if (CountInArr(arr1[i], arr2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    static void Main(string[] args)
        {
            int[] arr = BuildArr(10);
            PrintArr2(arr);
            Console.WriteLine();
            int[] newArr = OnlyPositive(arr);
            PrintArr(newArr);
            int[] arr2 = { 1,2,3,4,4,5,6,7};
            Console.WriteLine(TwiceInArr(arr2));
        }
    }
}
