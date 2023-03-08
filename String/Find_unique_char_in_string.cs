// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the non-repeated characters or unique characters in a given string? Write a program to find the unique characters in a string?
// Demo		: Non-Repeated Characters

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";
		
		
		Console.WriteLine("Input String : " + inputString);		
		Console.WriteLine("Non Repeated Character (Case Sensitive) List : \n");	
		NonRepeatedCharacters(inputString);
	}	  	
	
	public static void NonRepeatedCharacters(string inputString)    
	{               
            var charCountResult = CharCountDictionary(inputString);              
			
            foreach (var count in charCountResult)    
            {    
				if(count.Value == 1)
				{
                	Console.WriteLine(" {0} - {1} ", count.Key, count.Value);   
				}
            }    
	}    
	
	public static SortedDictionary<char, int> CharCountDictionary(string input)    
	{    
	 	SortedDictionary<char, int> countDict = new SortedDictionary<char, int>();    

				foreach (char item in input)    
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

// Input String : Tech Point Fundamentals
// Non Repeated Character (Case Sensitive) List : 

//  F - 1 
//  P - 1 
//  T - 1 
//  c - 1 