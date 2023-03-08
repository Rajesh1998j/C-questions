// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you sort an array in descending order? Write a program to sort an array in descending.
// Demo		: Sorting Array Elements Descending

using System;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {5, 1, 6, 2, 7, 3, 8, 4};			
		
		Console.WriteLine("UnSorted Array: ");	
		Console.WriteLine("----------------------------------------------------- ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		// Sorting using User Defined Function
		var sortedArray = SortArray(unsortedArray);
		
		Console.WriteLine("\nDescending Sorted Array Without Any Library Function: ");	
		Console.WriteLine("----------------------------------------------------- ");	
		for( int i = 0; i <= sortedArray.Length - 1; i++)
		{
			Console.WriteLine(sortedArray[i]);
		}		
		
		// Sorting using Library Function
		 Array.Sort(unsortedArray);
         Array.Reverse(unsortedArray);
		
		Console.WriteLine("\nDescending Sorted Array With Library Function: ");	
		Console.WriteLine("----------------------------------------------------- ");	
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
				 if (array[i] < array[j]) {
  
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
// ----------------------------------------------------- 
// 5
// 1
// 6
// 2
// 7
// 3
// 8
// 4

// Descending Sorted Array Without Any Library Function: 
// ----------------------------------------------------- 
// 8
// 7
// 6
// 5
// 4
// 3
// 2
// 1

// Descending Sorted Array With Library Function: 
// ----------------------------------------------------- 
// 8
// 7
// 6
// 5
// 4
// 3
// 2
// 1