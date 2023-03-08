// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you remove the even numbers from an integer array? Write a program for the same.
// Demo		: Removing Even Numbers from Array 

using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {5, 3, 6, 2, 1, 4, 8, 7};			
				
		Console.WriteLine("UnSorted Array With Even and Odd Elements: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		// Removing Even Numbers using User Defined Function
		var oddArray = RemoveEvenNumbers(unsortedArray);
		
		Console.WriteLine("\nArray After Removing Even Numbers Using UDF: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i <= oddArray.Length - 1; i++)
		{
			Console.WriteLine(oddArray[i]);
		}	
		
		// Removing Even Numbers using LINQ Library Function
		 var oddArrayLinq = unsortedArray.Distinct().Where( r => r % 2 != 0).ToArray();
		
		Console.WriteLine("\nArray After Removing Even Numbers Using LINQ: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i <= oddArrayLinq.Length - 1; i++)
		{
			Console.WriteLine(oddArrayLinq[i]);
		}	
	}	
	
	static int [] RemoveEvenNumbers(int[] array)
	{		
		int m = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] % 2 != 0)  
			{
				array[m] = array[i];   
				++m;
			}
		}
		int[] temp = new int[m];
		for (int i = 0; i < m; i++)
			temp[i] = array[i];

		array = temp;
		return array;  
	}		
}

// UnSorted Array With Even and Odd Elements: 
// ------------------------------------------------ 
// 5
// 3
// 6
// 2
// 1
// 4
// 8
// 7

// Array After Removing Even Numbers Using UDF: 
// ------------------------------------------------ 
// 5
// 3
// 1
// 7

// Array After Removing Even Numbers Using LINQ: 
// ------------------------------------------------ 
// 5
// 3
// 1
// 7