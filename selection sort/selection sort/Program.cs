using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[50];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 51);
            }

            Console.WriteLine("******** Selection sort Algorithm********");
            Console.WriteLine("Orignal Datset:");
            Display(nums);
            InsertionSort(nums);
            SelectionSort(nums);
            BubbleSort(nums);
            Display(nums);
        }
        static void SelectionSort(int[] nums) { 
            for (int outter = 0; outter < nums.Length; outter++)
            {
                int min = outter;
                for (int inner = outter + 1; inner < nums.Length; inner++)
                {
                    if (nums[inner] < nums[min])
                        min = inner;
                }
                int temp = nums[outter];
                nums[outter] = nums[min];
                nums[min] = temp;
            }

            Console.WriteLine("\n Sorted Datset:");
            Display(nums);

        }
       
        static void Display(int[] nums)
        {
            foreach (int x in nums)
                Console.Write(x + "\t");

            Console.WriteLine();
            Console.ReadLine();
        }
        static void InsertionSort(int[] _nums)
        {
            int temp;
            int j;
            for (int i =1; i< _nums.Length; i++)
            {
                j = i;
                temp = _nums[i];
                while (j > 0 && _nums[j - 1] >= temp)
                {
                    _nums[j] = _nums[j - 1];
                    j -= 1;
                }
                _nums[j] = temp;
            }
            foreach (int x in _nums)
                Console.WriteLine(x + "\t");
            Console.ReadLine();
        }
        static void BubbleSort( int[] _nums)
        {

            Stopwatch s1 = new Stopwatch();
            s1.Start();
            s1.Stop();
            for ( int i = 0; i< _nums.Length -1; i++)
            {
                for (int j = 0; j < _nums.Length - 1; j++)
                {
                    if (_nums[j]> _nums[j + 1])
                    {
                        int temp = _nums[j + 1];
                        _nums[j + 1] = _nums[j];
                        _nums[j] = temp;
                    }
                }

            }
            Console.WriteLine("Standard Bubble Sort: " + s1.Elapsed);
        }
    }
}
