// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the total number of occurrences of a given string or word in a paragraph or sentence? Write a program to find the same.
// Demo		: Occurrence Count of a Word

using System;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals Tech Point Tech Fundamentals www.techpointfunda.com";		
		string inputWord = "Tech";		
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Input Word : " + inputWord);		
		Console.WriteLine("Word Max Count : " + CharacterCount(inputString, inputWord));		
	}	  	
	
	public static int CharacterCount(string inputString, string word)    
	{  		
		int count = 0;		
		word = word.ToLower();
		string[] wordArray = inputString.ToLower().Split(' '); 				
		
		foreach (string item in wordArray)
		{
			if (item == word)
			{
				count = count + 1;
			}
		}
		
		return count;
	}	
}

// Input String : Tech Point Fundamentals Tech Point Tech Fundamentals www.techpointfunda.com
// Input Word : Tech
// Word Max Count : 3