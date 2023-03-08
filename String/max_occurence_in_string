// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the character having maximum occurrence in a given string? Write a program to find the character having max count in a given string.
// Demo		: Character Having Maximum Occurrence in String

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";		
		int maxCharCount;
		char maxChar;
		MaxOccurrenceCharacter(inputString, out maxChar, out maxCharCount);
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Character Having Max Occurance : " + maxChar);
		Console.WriteLine("Character Max Count : " + maxCharCount);
		
	}
	  	
	
	public static void MaxOccurrenceCharacter(string inputString, out char character, out int count)    
	{  
		character = ' ';
		count = 0;		
		
		char[] charArray = inputString.ToLower().ToCharArray(); 

		Dictionary<char, int> countDictionary = new Dictionary<char, int>();
		
		for (int i = 0; i < charArray.Length; i++)
		{
			if (charArray[i] != ' ')
			{
				if (!countDictionary.ContainsKey(charArray[i]))
				{
					countDictionary.Add(charArray[i], 1);
				}
				else
				{
					countDictionary[charArray[i]]++;
				}
			}
		}

		foreach (KeyValuePair<char, int> item in countDictionary)
		{
			if (item.Value > count)
			{
				character = item.Key;
				count = item.Value;
			}
		}		
	}	
}

// Input String : Tech Point Fundamentals
// Character Having Max Occurance : t
// Character Max Count : 3