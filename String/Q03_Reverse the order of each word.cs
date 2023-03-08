// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you reverse the order of each word in a given sentence? Write a program to reverse the order of each word in a given sentence.
// Demo		: Reverse the order of each word

using System;
using System.Text;


public class Program
{
	public static void Main()
	{
		string inputString = "Tech Point Fundamentals";
		string reversedString = ReverseWordOrder(inputString);
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Reversed Word Order (Way-1) : " + reversedString);
		Console.WriteLine("Reversed Word Order (Way-2) : " + ReverseWordOrder_Way2(inputString));
		Console.WriteLine("Reversed Word Order (Way-3) : " + ReverseWordOrder_Way3(inputString));
	}
	
	static string ReverseWordOrder(string inputString)  
	{        
		string reversedWordOrder = "";
		string[] charArray = inputString.Split(' ');		
           
            for(int i = charArray.Length-1; i >= 0; i--)
                reversedWordOrder += charArray[i] + " ";
		
		return reversedWordOrder;		
	}
	
	static string ReverseWordOrder_Way2(string inputString)  
	{        
		string reversedWordOrder = "";
		string word = "";
		
		for (int i = inputString.Length - 1; i >= 0; i--)
		{
			if (inputString[i].ToString() != " ")
				word = inputString[i] + word;
			else
			{
				reversedWordOrder = reversedWordOrder + " " + word;
				word = "";
			}
		}
		
		reversedWordOrder = reversedWordOrder + " " + word;		
		return reversedWordOrder.Trim();		
	}
	
	static string ReverseWordOrder_Way3(string inputString)  
	{        
		StringBuilder reversedWordOrder = new StringBuilder();
		int index;
		int startIndex = inputString.Length - 1;
		int endIndex = inputString.Length - 1;		
		
		while (startIndex > 0)  
    	{  
			if (inputString[startIndex] == ' ')  
			{  
				index = startIndex + 1;  
				while (index <= endIndex)  
				{  
					reversedWordOrder.Append(inputString[index]);  
					index++;  
				}  
				reversedWordOrder.Append(' ');  
				endIndex = startIndex - 1;  
			}  
			startIndex--;  
    	}  
  
		for (index = 0; index <= endIndex; index++)  
		{  
			reversedWordOrder.Append(inputString[index]);  
		} 
					
		return reversedWordOrder.ToString();		
	}
}


// Input String : Tech Point Fundamentals
// Reversed Word Order (Way-1) : Fundamentals Point Tech 
// Reversed Word Order (Way-2) : Fundamentals Point Tech
// Reversed Word Order (Way-3) : Fundamentals Point Tech