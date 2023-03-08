// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the majority element in an unsorted array? Write a program to find the majority element in an array.
// Demo		: Majority Array Element

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[10] {3, 3, 6, 3, 1, 3, 8, 3, 7, 3};			
				
		Console.WriteLine("Input UnSorted Array: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		// Majority Array Element
		var majorityElement = MajorityElement(unsortedArray);
		
		Console.WriteLine("\nMajority Array Element: " + majorityElement);	
						
	}	
	
	 public static int MajorityElement(int[] array)
	 {
		 Dictionary<int, int> dictionary = new Dictionary<int, int>();
		 int majority = array.Length / 2;
		
		 foreach (int i in array)
		 {
			 if (dictionary.ContainsKey(i))
			 {
				 dictionary[i]++;				
				 if (dictionary[i] > majority)
					 return i;
			 }
		 	 else
			 	dictionary.Add(i, 1);		 
		 		
		 }
		 throw new Exception("No Majority Element Found in the Array");
	 }	
}

// Input UnSorted Array: 
// ------------------------------------------------ 
// 3
// 3
// 6
// 3
// 1
// 3
// 8
// 3
// 7
// 3

// Majority Array Element: 3