// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you sort an array without using any array library function? Write a program to sort an array.
// Demo		: Sorting Array Elements

using System;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {5, 1, 6, 2, 7, 3, 8, 4};			
				
		Console.WriteLine("UnSorted Array: ");	
		Console.WriteLine("------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		// Sorting using User Defined Function
		var sortedArray = SortArray(unsortedArray);
		
		Console.WriteLine("\nSorted Array Without Library Function: ");	
		Console.WriteLine("------------------------------------------ ");	
		for( int i = 0; i <= sortedArray.Length - 1; i++)
		{
			Console.WriteLine(sortedArray[i]);
		}	
		
		// Sorting using Library Function
		 Array.Sort(unsortedArray);
		
		Console.WriteLine("\nSorted Array Using Library Function: ");	
		Console.WriteLine("------------------------------------------ ");	
		for( int i = 0; i <= unsortedArray.Length - 1; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}	
	}	
	
	 public static int[] SortArray(int[] array)
	 {		
		 int temp = 0;
		 for (int i = 0; i < array.Length ; i++)
		 {
			for (int j = i+1; j < array.Length ; j++)
		 	{
				 if (array[i] > array[j]) {
  
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
		 	} 
		 }
         return array;
     }
}

// UnSorted Array: 
// ------------------------------------------ 
// 5
// 1
// 6
// 2
// 7
// 3
// 8
// 4

// Sorted Array Without Library Function: 
// ------------------------------------------ 
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8

// Sorted Array Using Library Function: 
// ------------------------------------------ 
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8