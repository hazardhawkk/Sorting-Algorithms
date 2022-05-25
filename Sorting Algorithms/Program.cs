using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfIntegers = {2,8,4,1,8,3,2,63,7,2,5};
            

            BinarySearch(arrOfIntegers, 5, arrOfIntegers.Length-1);

        }
        //helper functions:
        static void WriteArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write( arr[i]+", ");
            }
        }

        static int[] GenerateArray(int arrLength, int max=1000)
        {
            Random rd = new Random();                   
            int[] arr = new int[arrLength];
            int randNum;

            for (int i = 0; i < arr.Length; i++)
            {
                randNum = rd.Next(0, max);
                arr[i] = randNum;
            }

            return arr;
        }
        //sorting algorithms:
        static void BubbleSort(int[] arr)
        {
            Console.WriteLine("Unsorted Array:");       //writing unsorted
            WriteArray(arr);                    
            Console.WriteLine();

            int temp = 0;

                for (int i = 0;i<arr.Length-1;i++)          //itterating through passes
                {

                  for (int j = 0; j < arr.Length-1; j++)     //itterating through items
                  {


                    if (arr[j] > arr[j + 1])         //swapping if j bigger than j+1
                    {
                        temp = arr[j];
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

            Console.WriteLine("Unsorted Array:");       //writing unsorted
            WriteArray(arr);                    
            Console.WriteLine();

                for (int i = 0;i<arr.Length-1 || swaps_made==true;i++)          //itterating through passes until no swaps are made in a pass or we have gone through the whole arr so are guaranteed to have sorted it
            {

                  for (int j = 0; j < arr.Length - (1+i); j++)     //itterating through items for the length of the array excluding items at the end which are guaranteed to be in correct place
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
            int i = 0;
            Console.WriteLine("Unsorted Array:");       //writing unsorted
            WriteArray(arr);                    
            Console.WriteLine();

            while (swaps_made==true || i < arr.Length-1)   //itterating through passes until no swaps are made in a pass or we have gone through the whole arr so are guaranteed to have sorted it
            { 
                  for (int j = 0; j < arr.Length - (1+i); j++)     //itterating through items for the length of the array excluding items at the end which are guaranteed to be in correct place
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
        
        static void InsertionSort(int[] arr)
        {
            Console.WriteLine("Unsorted Array:");       //writing unsorted
            WriteArray(arr);                    
            Console.WriteLine();

            int currentItem = 0;
            int previousIndex = 0;

            

            for (int i = 1; i < arr.Length; i++)          //itterating through arr starting at second item (index 1)
			{
               currentItem= arr[i];    //<-- variable created to not lose the value of current item
               previousIndex = i-1;

                while (previousIndex >= 0 && arr[previousIndex] > currentItem)  //iterating through inserting each previous item in correct place by moving it up the array
                {
                    arr[previousIndex+1] = arr[previousIndex];

                    previousIndex = previousIndex-1;
                }
                arr[previousIndex+1] = currentItem;        //+1 bc we have checked one behind the correct position
	
			}





            Console.WriteLine("Sorted Array:");       //writing sorted
            WriteArray(arr); 
        }

        static bool LinearSearch(int[] arr, int target)
        {
            bool result = false;

            for (int i = 0; i < arr.Length && result==false; i++)
            {
                if(arr[i] == target)
                {
                    result = true;
                }
            }

            return result;
        }

        static bool BinarySearch(int[] arr, int target, int arrEnd, int arrStart=0)
        {
            int arrLength = arrEnd - arrStart;
            int midIndex = arrLength / 2;
            int mid = arr[midIndex];
            
            if(mid!=target && arrLength==0) { return false; }
            else if (mid == target) { return true; }
            else if (mid > target) { return BinarySearch(arr, target, midIndex-1); }
            else{ return BinarySearch(arr, target, midIndex+1, arrEnd); } //if mid < target

        }
    }
}
