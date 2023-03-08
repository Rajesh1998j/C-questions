// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you reverse an unsorted array without using and library function or sorting? Write a program to reverse an array.
// Demo		: Reversing Array Elements

using System;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {5, 3, 6, 2, 1, 4, 8, 7};			
				
		Console.WriteLine("Input UnSorted Array: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		// Reversing Array using User Defined Function
		var reversedArray = ReverseArray(unsortedArray);
		
		Console.WriteLine("\nArray After Reversing the Element: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i <= reversedArray.Length - 1; i++)
		{
			Console.WriteLine(reversedArray[i]);
		}		
		
		// Reverse using Array Function
		// Array.Reverse(unsortedArray);			
	}	
	
	static int [] ReverseArray(int[] array)
	{		
		int temp = 0;
		for (int i = 0; i < array.Length / 2; i++) { 
            temp = array[i]; 
            array[i] = array[array.Length - i - 1]; 
            array[array.Length - i- 1] = temp; 
        } 
		return array;  
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

// Array After Reversing the Element: 
// ------------------------------------------------ 
// 7
// 8
// 4
// 1
// 2
// 6
// 3
// 5