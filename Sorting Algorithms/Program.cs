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

                for (int i = 0;i<arr.Length-2;i++)          //itterating through passes
                {

                  for (int j = 0; j < arr.Length-2; j++)     //itterating through items
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

        static void OptimizedBubbleSortWithForLoop(int[] arr)
        {
            bool swaps_made = true;
            int passes_made = 1;

            Console.WriteLine("Unsorted Array:");       //writing unsorted
            WriteArray(arr);                    
            Console.WriteLine();

                for (int i = 0;i<arr.Length-2 || swaps_made==true;i++)          //itterating through passes
                {

                  for (int j = 1; j < arr.Length - passes_made; j++)     //itterating through items
                  {
                    swaps_made=false;

                    if (arr[j] > arr[j + 1])         //swapping if j bigger than j+1
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaps_made=true;
                    }
                    

                  }

                }
            Console.WriteLine("Sorted Array:");       //writing sorted
            WriteArray(arr); 
        }

        static void OptimizedBubbleSortWithWhileLoop(int[] arr)
        {
            bool swaps_made = true;
            int i=0    //counting through while loop
            int passes_made = 1;

            Console.WriteLine("Unsorted Array:");       //writing unsorted
            WriteArray(arr);                    
            Console.WriteLine();

            while (swaps_made==true || i<arr.Length-2)   //itterating through passes until no swaps are made in a pass or we have gone through the whole arr so are guaranteed to have sorted it
            { 
                  for (int j = 1; j < arr.Length - passes_made; j++)     //itterating through items for the length of the array excluding items at the end which are guaranteed to be in correct place
                  {
                     swaps_made=false;
                    if (arr[j] > arr[j + 1])         //swapping if j bigger than j+1
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                      swaps_made=true;
                    }
                  }
                  i++; 
            }
            Console.WriteLine("Sorted Array:");       //writing sorted
            WriteArray(arr); 
        }
    }
}
