// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the largest and smallest element of a given unsorted array? Write a program for the same.
// Demo		: Largest and Smallest Array Element

using System;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {5, 3, 6, 2, 1, 4, 8, 7};			
		int maxElement, minElement;
		
		Console.WriteLine("Input UnSorted Array: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		MaxMinArrayElement(unsortedArray, out maxElement, out minElement);
			
		Console.WriteLine(string.Format("\n\nLargest Element : {0}, Smallest Element : {1}", maxElement, minElement));
		
	}		
		
	static void MaxMinArrayElement(int[] array,  out int largest, out int smallest)
	{		
		largest = array[0];
		smallest = array[0];			
		
		  for(int i = 1; i < array.Length; i++)
		  {
			 if(array[i] > largest) 
			 {
				largest = array[i];
			 }
			 if(array[i] < smallest)
			 {
				smallest = array[i];
			 }
		  }		
	}	
}

// Input UnSorted Array: 
// ------------------------------------------------ 
// 5
// 3
// 6
// 2
// 1
// 4
// 8
// 7


// Largest Element : 8, Smallest Element : 1