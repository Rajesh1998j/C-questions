// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the frequency of each element of an array? Write a program to count the frequency of each element of an array?
// Demo		: Frequency of Each Array Element

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {1, 2,  6, 4, 3, 4, 2, 4};			
				
		Console.WriteLine("Input UnSorted Array: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}		
		
		Console.WriteLine("\n\nFrequency of Each Array Element: ");	
		Console.WriteLine("------------------------------------------------ ");	
		FrequencyCount(unsortedArray);					
	}	
	
	public static void FrequencyCount(int[] inputArray)    
	{               
		var frequenyCount = CharCountDictionary(inputArray);             

		foreach (var count in frequenyCount)    
		{    
			Console.WriteLine(" {0} : {1} Times", count.Key, count.Value);    
		}    
	}   
	
	public static SortedDictionary<int, int> CharCountDictionary(int[] inputArray)    
	{    
	 	SortedDictionary<int, int> countDict = new SortedDictionary<int, int>();    

		foreach (int item in inputArray)    
		{    
			if (!(countDict.ContainsKey(item)))    
			{    
				countDict.Add(item, 1);    
			}    
			else    
			{    
				countDict[item]++;    
			}    
		}    

		return countDict;    
	} 
}


// Input UnSorted Array: 
// ------------------------------------------------ 
// 1
// 2
// 6
// 4
// 3
// 4
// 2
// 4


// Frequency of Each Array Element: 
// ------------------------------------------------ 
//  1 : 1 Times
//  2 : 2 Times
//  3 : 1 Times
//  4 : 3 Times
//  6 : 1 Times
// ;