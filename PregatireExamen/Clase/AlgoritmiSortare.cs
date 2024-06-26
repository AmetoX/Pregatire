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

        private void CreateArray()
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

        public void BubbleSort()//int[] v) //teoretic primeste ca parametru vecotorul
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

        public void SelectionSort() // (int[] array)
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

        public void InsertionSort() // (int[] array)
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

        // BK
        public void BK()
        {
            //produs cartezian; interval [1,5] la putera a 5a
            int n = 5;
            int p = 3;
            int[] s = new int[n];
            bool[] b = new bool[n];

            //PK(0, n, s);
            //Permutari(0, n, s, b);
            //Aranjamente(0, n, p, s, b);

            //s[0] = 0;
            //Combinari(1, n, p, s);
        }

        public static void PK(int k, int n, int[] sol) // produs cartezian
        {
            if (k >= n)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(sol[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = 0; i <= 5; i++)
                {
                    sol[k] = i + 1;
                    PK(k + 1, n, sol);
                }
            }
        }

        public static void Permutari(int k, int n, int[] s, bool[] b)
        {
            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        s[k] = i + 1; b[i] = true;
                        Permutari(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }

        public static void Aranjamente(int k, int n, int p, int[] s, bool[] b)
        {
            if (k >= p)
            {
                for (int i = 0; i < p; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        s[k] = i + 1; b[i] = true;
                        Aranjamente(k + 1, n, p, s, b);
                        b[i] = false;
                    }
                }
            }
        }

        public static void Combinari(int k, int n, int p, int[] s)
        {
            if (k > p)
            {
                for (int i = 1; i <= p; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = s[k - 1] + 1; i <= n; i++)
                {
                    s[k] = i;
                    Combinari(k + 1, n, p, s);
                }
            }
        }

        //bk cu caractere
        //aranjamentele unui cuvant cu urmatoarele reguli:
        //nu contine consoane trei consoane consecutive
        //sa nu fie 2 litere identice consecutive
        public static void MainCmds()
        {
            Console.Write("Introduceți un cuvânt: ");
            string input = Console.ReadLine().ToLower();

            List<string> anagrams = GenerateAnagrams(input);
            Console.WriteLine("Anagramele generate sunt:");
            foreach (var anagram in anagrams)
            {
                Console.WriteLine(anagram);
            }
        }

        static List<string> GenerateAnagrams(string input)
        {
            List<string> result = new List<string>();
            Permute(input.ToCharArray(), 0, input.Length - 1, result);
            return result;
        }

        static void Permute(char[] arr, int l, int r, List<string> result)
        {
            if (l == r)
            {
                string permutation = new string(arr);
                if (IsValidAnagram(permutation))
                {
                    result.Add(permutation);
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    Swap(ref arr[l], ref arr[i]);
                    Permute(arr, l + 1, r, result);
                    Swap(ref arr[l], ref arr[i]);
                }
            }
        }

        static bool IsValidAnagram(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (IsConsonant(input[i]) && IsConsonant(input[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsConsonant(char c)
        {
            return "bcdfghjklmnpqrstvwxyz".Contains(c);
        }

        static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }


        //bk patrat perfect
        static void Test02BK()//generare patrat perfect
        {
            int n = 9;
            int[] s = new int[n];
            bool[] b = new bool[n];
            BK(0, n, s, b);
        }
        static void BK(int k, int n, int[] s, bool[] b)
        {
            if (k >= n)
            {
                int sl1 = s[0] + s[1] + s[2];
                int sl2 = s[3] + s[4] + s[5];
                int sl3 = s[6] + s[7] + s[8];

                int sc1 = s[0] + s[3] + s[6];
                int sc2 = s[1] + s[4] + s[7];
                int sc3 = s[2] + s[5] + s[8];

                int sd1 = s[0] + s[4] + s[8];
                int sd2 = s[2] + s[4] + s[6];
                if (sl1 == sl2 && sl1 == sl3 && sl1 == sc1 && sl1 == sc2 && sl1 == sc3 && sl1 == sd1 && sl1 == sd2)
                {
                    int l = 0;
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                        l++;
                        if (l == 3)
                        {
                            Console.WriteLine();
                            l = 0;
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BK(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}
