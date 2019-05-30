using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] nums = new int[100000];

            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next (1,100001);
            }
            InsertionSort(arr);
            ImprovedBubbleSort(arr);

        }
        static void InsertionSort(int[] _arr)
        {
            int[] arr = new int[10];
            Stopwatch InsertionSortStopwatch = new Stopwatch();
            int temp;
            int j;

            for (int i = 1; i < arr.Length; i++)
            {
                j = i;
                temp = arr[i];
                while (j > 0 && arr[j - 1] >= temp)
                {
                    arr[j] = arr[j - 1];
                    j -= 1;
                }
                arr[j] = temp;
            }

            foreach (int x in arr)
                Console.WriteLine(x);
            Console.ReadLine();
        }
        static void ImprovedBubbleSort(int[] _arr)
        {
            Stopwatch BubbleSortStopwatch = new Stopwatch();
            for (int i =0; i < Array<)
        }
    }
}
