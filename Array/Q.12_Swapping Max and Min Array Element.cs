// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you swap max and min elements in an integer array? Write a program for the same.
// Demo		: Swapping Max and Min Array Element

using System;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {1, 5,  6, 8, 3, 7, 2, 4};			
				
		Console.WriteLine("Input UnSorted Array: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}		
		
		var arrayAfterSwapping = MinMaxArraySwap(unsortedArray);
		
		Console.WriteLine("\n\nArray After Min Max Element Swapping: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < arrayAfterSwapping.Length; i++)
		{
			Console.WriteLine(arrayAfterSwapping[i]);
		}						
	}	
	
	public static int[] MinMaxArraySwap(int[] array)
	{
		int min = 0;
		int max = 0;

		for (int i = 1; i < array.Length; i++)
		{
			if (array[min] > array[i])
				min = i;
			if (array[max] < array[i])
				max = i;
		}
		int temp = array[min];
		array[min] = array[max];
		array[max] = temp;
		
		return array;
	}
}


// Input UnSorted Array: 
// ------------------------------------------------ 
// 1
// 5
// 6
// 8
// 3
// 7
// 2
// 4


// Array After Min Max Element Swapping: 
// ------------------------------------------------ 
// 8
// 5
// 6
// 1
// 3
// 7
// 2
// 4
// ;