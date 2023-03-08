// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find and return the first character of each word in the capital letter for a given sentence? Write a program for the same.
// Demo		: Finding First Character of Each Word

using System;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";		
		
		Console.WriteLine("Input String : " + inputString);		
		Console.WriteLine("First Characters of Each Word : ");	
		FirstCharacterOfWords(inputString);
	}	  	
	
	public static void FirstCharacterOfWords(string inputString)    
	{               
         	if (!string.IsNullOrWhiteSpace(inputString))
            {
                string[] wordArray = inputString.Split(' ');

                foreach (string item in wordArray)
                {
                    Console.WriteLine(String.Format("{0} : {1}", item, item.Substring(0, 1).ToUpper()));
                }              
            }
	}	
}


// Input String : Tech Point Fundamentals
// First Characters of Each Word : 
// Tech : T
// Point : P
// Fundamentals : F