// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How to check whether an array contains duplicate values or not? Write a program to check if an array contains duplicates.
// Demo		: Checking Array Duplicate Element

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {1, 2, 6, 4, 3, 4, 2, 4};			
				
		Console.WriteLine("Input Array: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}				
		
		Console.WriteLine("\n\nIs Array Contains Duplicate Elements : " + IsArrayContainsDuplicates(unsortedArray));						
	}	 
	
	public static bool IsArrayContainsDuplicates(int[] inputArray)    
	{    
	 	Dictionary<int, int> d = new Dictionary<int, int>();
		foreach (int i in inputArray)
		{
			if (d.ContainsKey(i))
				return true;
			else
				d.Add(i, 1);
		}
		return false;		
	} 
}


// Input Array: 
// ------------------------------------------------ 
// 1
// 2
// 6
// 4
// 3
// 4
// 2
// 4


// Is Array Contains Duplicate Elements : True