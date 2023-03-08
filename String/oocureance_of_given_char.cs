// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the total number of occurrences of a given character in a string? Write a program to find the same.
// Demo		: Occurrence Count of a Character

using System;


public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";		
		char inputCharacter = 't';		
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Input Character : " + inputCharacter);		
		Console.WriteLine("Character Max Count - Way 1 : " + CharacterCount(inputString, inputCharacter));	
		Console.WriteLine("Character Max Count - Way 2 : " + CharacterCount_Way2(inputString, inputCharacter));
	}	  	
	
	public static int CharacterCount(string inputString, char character)    
	{  		
		int count = 0;		
		
		char[] charArray = inputString.ToLower().ToCharArray(); 				
		
		foreach (char item in charArray)
		{
			if (item == character)
			{
				count = count + 1;
			}
		}
		
		return count;
	}	
	
	public static int CharacterCount_Way2(string inputString, char character)    
	{  		
		int count = 0;
		inputString = inputString.ToLower();
		
		for (int index = 0; index < inputString.Length; index++)
		{
			if (inputString[index] == character)
			{
				count = count + 1;
			}
		}
		
		return count;
	}	
}

// Input String : Tech Point Fundamentals
// Input Character : t
// Character Max Count - Way 1 : 3
// Character Max Count - Way 2 : 3