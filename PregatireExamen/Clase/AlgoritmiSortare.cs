using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;



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

        public void MergeRun()
        {
            MergeSort(array,0, array.Length-1);
        }
        private void MergeSort(int[] arr, int left, int right)  //mergesort main function
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }

            //MergeSort Method:

            //If the current array segment has more than one element, it finds the middle point.
            //Recursively sorts the left half and the right half.
            //Merges the two sorted halves using the Merge method.

            //Merge Method:

            //Creates temporary arrays for the two halves.
            //Copies the elements into the temporary arrays.
            //Merges the elements from the temporary arrays back into the original array in sorted order.
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

        public void SelectionSort()
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

            //SelectionSort Method:

            //Iterates through the array, finding the minimum element in the unsorted part of the array and swapping it with the first unsorted element.
            //The outer loop tracks the boundary between sorted and unsorted sections of the array.
            //The inner loop finds the index of the minimum element in the unsorted part.
            //After finding the minimum element, it swaps it with the first unsorted element.
        }

        public void QuickSOrtRun()
        {
            QuickSort(array, 0, array.Length-1);
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Partition the array
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort elements before and after partition
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }

            //QuickSort Method:

            //Recursively sorts the array by partitioning it and then sorting the partitions.

            //Partition Method:

            //Selects a pivot element(in this case, the last element of the array).
            //Rearranges the array so that elements less than the pivot come before it and elements greater come after it.
            //Places the pivot in its final position.
            //Returns the index of the pivot.
        }

        private static int Partition(int[] arr, int low, int high)
        {
            // Choose the pivot element
            int pivot = arr[high];

            int i = (low - 1); // Index of smaller element

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (arr[j] <= pivot)
                {
                    i++;
                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public void InsertionSort()
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }

            //InsertionSort Method:

            //Iterates through the array starting from the second element.
            //For each element, finds its correct position in the sorted part of the array and inserts it there.
        }

        public void Divide_Empera()
        {
            //ii defapt Alg merge sort
        }

        public void BK()
        {

        }
    }
}
