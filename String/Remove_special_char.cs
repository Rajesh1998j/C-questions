// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find and remove the special characters from a string? Write a program to remove the special characters from a string.
// Demo		: Removing Special Characters

using System;
using System.Text.RegularExpressions;
using System.Text;

public class Program
{
	public static void Main()
	{
		string inputString = "www.techpointfunda.com";		
		
		Console.WriteLine("Input String : " + inputString);		
		Console.WriteLine("After Removing Special Characters By Replace Method : " + RemovingSpecialCharactersByRegex(inputString));	
		Console.WriteLine("After Removing Special Characters By REGEX : " + RemovingSpecialCharactersByRegex(inputString));		
		Console.WriteLine("After Removing Special Characters By Loop : " + RemovingSpecialCharactersByLoop(inputString));
	}	  	
	
	public static string RemovingSpecialCharacters(string inputString)    
	{               
         	string output = string.Empty;  
		
		 	output = inputString.Replace("[^a-zA-Z0-9]"," ");
		 	return output;
	}  
	
	public static string RemovingSpecialCharactersByLoop(string inputString)    
	{               
         	StringBuilder output = new StringBuilder();
    		foreach (char c in inputString)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    output.Append(c);
                }
            }
		 	return output.ToString();
	}    
	
	public static string RemovingSpecialCharactersByRegex(string inputString) 
	{
		 return Regex.Replace(inputString, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
	}	
}

// Input String : www.techpointfunda.com
// After Removing Special Characters By Replace Method : wwwtechpointfundacom
// After Removing Special Characters By REGEX : wwwtechpointfundacom
// After Removing Special Characters By Loop : wwwtechpointfundacom