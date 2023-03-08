// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you reverse each word in a given sentence? Write a program to reverse each word of a given sentence.
// Demo		: Reverse each word of the sentence

using System;
using System.Text;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";
		string reversedString = ReverseWord(inputString);
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Reversed Word : " + reversedString);
	}
	
	static string ReverseWord(string inputString)  
	{        
		StringBuilder reversedWord = new StringBuilder();  
     	List<char> charList = new List<char>();  
  
		 for (int i = 0; i < inputString.Length; i++)  
		 {  
			 if (inputString[i] == ' ' || i == inputString.Length - 1)  
			 {  
				 if (i == inputString.Length - 1)  
					 charList.Add(inputString[i]);  
				 
				 for (int j = charList.Count - 1; j >= 0; j--)  
					 reversedWord.Append(charList[j]);  

				 reversedWord.Append(' ');  
				 charList = new List<char>();  
			 }  
			 else  
				 charList.Add(inputString[i]);  
		 }  
		
		return reversedWord.ToString();
		
	}
}