// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you check whether the given string is a palindrome or not? Write a program for checking palindrome.
// Demo		: Checking for Palindrome

using System;

public class Program
{
	public static void Main()
	{
		string inputString = "NAYAN";		
		string inputString2 = "12321";
		string inputString3 = "TechPointTech";
		
		Console.WriteLine(String.Format("Is \"{0}\" Palindrome : {1}", inputString, IsPalindrome(inputString)));	
		Console.WriteLine(String.Format("Is \"{0}\" Palindrome : {1}", inputString2, IsPalindrome(inputString2)));
		Console.WriteLine(String.Format("Is \"{0}\" Palindrome : {1}", inputString3, IsPalindrome(inputString3)));
		
	}	  	
	
	public static bool IsPalindrome(string inputString)    
	{	          
  		bool isPalindrome = false;  
		
		 for (int i = 0, j = inputString.Length - 1; i < inputString.Length / 2; i++, j--)  
		 {  
			 if (inputString[i] != inputString[j])  
			 {  
				 isPalindrome = false;  
				 break;  
			 }  
			 else  
				 isPalindrome = true;  
		 }  
		return isPalindrome;
	}	
}

// Is "NAYAN" Palindrome : True
// Is "12321" Palindrome : True
// Is "TechPointTech" Palindrome : False