// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you remove the duplicate elements from an integer array? Write a program for the same.
// Demo		: Removing Dupliate Array Elements 

using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {5, 3, 6, 2, 1, 3, 8, 5};			
				
		Console.WriteLine("UnSorted Array With Duplicate Elements: ");	
		Console.WriteLine("------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		// Removing Duplicates using User Defined Function
		var distinctArrayByHash = RemoveArrayDuplicates(unsortedArray);
		
		Console.WriteLine("\nDistinct Array Using HashSet: ");	
		Console.WriteLine("------------------------------------------ ");	
		for( int i = 0; i <= distinctArrayByHash.Length - 1; i++)
		{
			Console.WriteLine(distinctArrayByHash[i]);
		}	
		
		// Removing Duplicates using LINQ Library Function
		 var distinctArray = unsortedArray.Distinct().ToArray();
		
		Console.WriteLine("\nDistinct Array Using LINQ: ");	
		Console.WriteLine("------------------------------------------ ");	
		for( int i = 0; i <= distinctArray.Length - 1; i++)
		{
			Console.WriteLine(distinctArray[i]);
		}	
	}	
	
	public static T[] RemoveArrayDuplicates<T>(T[] array)
    {
        HashSet<T> set = new HashSet<T>(array);
        T[] result = new T[set.Count];
        set.CopyTo(result);
        return result;
    }	
	
}


// UnSorted Array With Duplicate Elements: 
// ------------------------------------------ 
// 5
// 3
// 6
// 2
// 1
// 3
// 8
// 5

// Distinct Array Using HashSet: 
// ------------------------------------------ 
// 5
// 3
// 6
// 2
// 1
// 8

// Distinct Array Using LINQ: 
// ------------------------------------------ 
// 5
// 3
// 6
// 2
// 1
// 8