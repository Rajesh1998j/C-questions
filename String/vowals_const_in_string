// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the total number of vowels and consonants in a given string? Write a program to find the number of vowels and consonants in a string.
// Demo		: Vowels and Consonants Count in String

using System;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";		
		int vowelCount,  ConsonentCount;
		VowelsConsonantsCount(inputString, out vowelCount, out ConsonentCount);
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Vowels Counts : " + vowelCount);
		Console.WriteLine("Consonants Counts : " + ConsonentCount);
		
	}
	  	
	
	public static void VowelsConsonantsCount(string inputString, out int vowelCount, out int ConsonentCount)    
	{  
		vowelCount = 0;
		ConsonentCount = 0;		
		
		char[] charArray = inputString.ToLower().ToCharArray(); 

		foreach(char item in charArray)
		{
			if(item != ' ')
			{
			if(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
				vowelCount = vowelCount + 1;
			else
				ConsonentCount = ConsonentCount + 1;	
			}
		}	
		
	}	
}


// output
// Input String : Tech Point Fundamentals
// Vowels Counts : 7
// Consonants Counts : 14