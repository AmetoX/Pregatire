using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PregatireExamen.Clase
{
    public class AlgoritmiSortare
    {
        int[] array;
        int count;
        public AlgoritmiSortare()
        {
            CreateArray();
            count = 0;
        }

        public void CreateArray()
        {
            Random rnd = new Random();
            array = new int[rnd.Next(0, 20)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1000);
            }
        }

        public void print()
        {
            Console.WriteLine($"Print {count}:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();           
            count++;
        }

        public void BubbleSort() //teoretic primeste ca parametru vecotorul
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap the elements
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public void MergeSort()
        {
            MergeSortRun(array,0, array.Length-1);
        }
        private void MergeSortRun(int[] arr, int left, int right)  //mergesort main function
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSortRun(arr, left, middle);
                MergeSortRun(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }
        private static void Merge(int[] arr, int left, int middle, int right) //merge sort second function
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = middle + 1, k = 0;

            while (i <= middle && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= middle)
            {
                temp[k++] = arr[i++];
            }

            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (i = left; i <= right; i++)
            {
                arr[i] = temp[i - left];
            }
        }

    }
}
