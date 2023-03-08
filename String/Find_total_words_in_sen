// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the total number of words in a given sentence? Write a program to find the no of words in a given sentence.
// Demo		: Number of Words in String

using System;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";		
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Word Counts With Split Function : " + WordCount(inputString));
		Console.WriteLine("Word Counts Without Split Function : " + WordCountWithoutSplitFunction(inputString));
		
	}
	
	public static int WordCount(string inputString)    
	{  
			string[] words = inputString.Split(' ');   
			return words.Length;
	}    	
	
	public static int WordCountWithoutSplitFunction(string inputString)    
	{  
			int wordCount = 1;
			char[] charArray = inputString.Trim().ToCharArray(); 
		
			foreach(char item in charArray)
			{
				if(item == ' ')
					wordCount = wordCount + 1;
			}		
			return wordCount;
	}	
}

// Input String : Tech Point Fundamentals
// Word Counts With Split Function : 3
// Word Counts Without Split Function : 3