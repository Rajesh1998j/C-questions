// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the total number of numeric characters in a string? Write a program to find the numeric characters in a string.
// Demo		: Finding Numeric Character in String

using System;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech 123 Point 498 Fundamentals 0";		
		
		Console.WriteLine("Input String : " + inputString);		
		Console.WriteLine("Numeric Characters Count : " + NumericCharactersCount(inputString));	
		
	}	  	
	
	public static int NumericCharactersCount(string inputString)    
	{		
        int count = 0;      
 
        for (int i = 0; i < inputString.Length; i++)
        {
            if ((inputString[i] >= '0') && (inputString[i] <= '9'))
            {
                count++;
            }
        }
		return count;
	}	
}

// Input String : Tech 123 Point 498 Fundamentals 0
// Numeric Characters Count : 7