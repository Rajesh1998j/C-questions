// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find and remove the duplicate characters from a string? Write a program to remove the duplicate characters from a string.
// Demo		: Removing Duplicate Characters

using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";		
		
		Console.WriteLine("Input String : " + inputString);		
		Console.WriteLine("After Removing Duplicate (Case Sensitive) Characters By IndexOf Method : " + RemovingDuplicateCharacters(inputString));	
		Console.WriteLine("After Removing Duplicate (Case Sensitive) Characters By LINQ : " + RemovingDuplicateCharactersByLINQ(inputString));
	}	  	
	
	public static string RemovingDuplicateCharacters(string inputString)    
	{               
         	string output = string.Empty;  
		
		 	foreach (char ch in inputString)
            {
                if (output.IndexOf(ch) == -1)
                {
                    output += ch;
                }
            }  
		 	return output;
	}    
	
	public static string RemovingDuplicateCharactersByLINQ(string inputString) 
	{
		 return new string(inputString.ToCharArray().Distinct().ToArray());
	}
	
}

// Input String : Tech Point Fundamentals
// After Removing Duplicate (Case Sensitive) Characters By IndexOf Method : Tech PointFudamls
// After Removing Duplicate (Case Sensitive) Characters By LINQ : Tech PointFudamls