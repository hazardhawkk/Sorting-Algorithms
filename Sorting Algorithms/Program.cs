using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfIntegers = {2,8,4,1,8,3,2,63,7,2,5};

            

            BubbleSort(arrOfIntegers);



        }
        static void WriteArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write( arr[i]+", ");
            }
        }
        static void BubbleSort(int[] arr)
        {
            Console.WriteLine("Unsorted Array:");       //writing unsorted
            WriteArray(arr);                    
            Console.WriteLine();

            for (int i = 0;i<arr.Length;i++)          //itterating through passes
                {

                  for (int j = 0; j < arr.Length-1; j++)     //itterating through items
                  {


                    if (arr[j] > arr[j + 1])         //swapping if j bigger than j+1
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    

                  }

                }
            Console.WriteLine("Sorted Array:");       //writing sorted
            WriteArray(arr); 
            
        }
    }
}
