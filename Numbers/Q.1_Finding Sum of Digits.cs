// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the sum of digits of a given positive integer? Write a program for the same.
// Demo		: Finding Sum of Digits

using System;

public class Program
{
	public static void Main()
	{
		int inputNumber = 9845;			
		
		Console.WriteLine("Input Number : " + inputNumber);	
		Console.WriteLine("Sum of Digits : " + SumOfDigits(inputNumber));	
		Console.WriteLine("Sum of Digits using Recursion: " + DigitSumRecursion(inputNumber));
	}	  	
	
	public static int SumOfDigits(int inputNumber)    
	{	          
  		int sum = 0;  
		while (inputNumber > 0)  
		{  
			sum += inputNumber % 10;  
			inputNumber /= 10;  
		}  
		return sum;
	}	
	
	public static int DigitSumRecursion(int inputNumber)    
	{	          
  		if (inputNumber != 0)
        {
            return (inputNumber % 10 + DigitSumRecursion(inputNumber / 10));
        }
        else
        {
            return 0;
        }
	}	
}

// Input Number : 9845
// Sum of Digits : 26
// Sum of Digits using Recursion: 26