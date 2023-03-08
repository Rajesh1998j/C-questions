// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you reverse a given number? Write a program to reverse a given number.
// Demo		: Reversing a Number

using System;

public class Program
{
	public static void Main()
	{
		int inputNumber = 9845;			
		
		Console.WriteLine("Input Number : " + inputNumber);	
		Console.WriteLine("Reverse Number : " + ReverseNumber(inputNumber));	
		Console.WriteLine("Reverse Number using Recursion : ");
		ReverseNumberRecursion(inputNumber);
	}	  	
	
	public static int ReverseNumber(int inputNumber)    
	{	          
  		int reverse = 0;
		int reminder;
		
		while (inputNumber != 0)  
		{  
			reminder = inputNumber % 10;  
			reverse = (reverse * 10) + reminder;
			inputNumber /= 10;  
		} 	
		
		return reverse;
	}	
	
	public static void ReverseNumberRecursion(int inputNumber)    
	{	          
  		if (inputNumber <= 0)
        {
            return;
        }
        else
        {
			Console.Write(inputNumber % 10);
            ReverseNumberRecursion(inputNumber / 10);
        }
	}	
}

// Input Number : 9845
// Reverse Number : 5489
// Reverse Number using Recursion : 
// 5489