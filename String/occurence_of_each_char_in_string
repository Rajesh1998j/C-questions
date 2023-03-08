// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the maximum occurrence of each character in a given string? Write a program to find the count of each character in a given string.
// Demo		: Occurrence of Each Character

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";		
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Character Counts : ");
		CharactersCount(inputString);
	}
	
	public static void CharactersCount(string inputString)    
	{               
            var charCountResult = CharCountDictionary(inputString);              
			
            foreach (var count in charCountResult)    
            {    
                Console.WriteLine(" {0} - {1} ", count.Key, count.Value);    
            }    
	}    
	
	public static SortedDictionary<char, int> CharCountDictionary(string input)    
	{    
	 	SortedDictionary<char, int> countDict = new SortedDictionary<char, int>();    

				foreach (char item in input)    
				{
					
					if (!(countDict.ContainsKey(item)) )    
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

// Input String : Tech Point Fundamentals
// Character Counts : 
//    - 2 
//  F - 1 
//  P - 1 