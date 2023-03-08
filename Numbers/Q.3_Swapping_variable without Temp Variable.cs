// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you swap two numbers without using a temp variable? Write a program that is free from the IntegerOverflow exception as well.
// Demo		: Swapping without Temp Variable

using System;

public class Program
{
	public static void Main()
	{
		int num1 = 10;			
		int num2 = 20;
		Console.WriteLine("Numbers Before Swapping : ");
		Console.WriteLine(String.Format("Number-1 : {0}, Number-2 : {1}", num1, num2));	
		Console.WriteLine("\n");
		Console.WriteLine("Numbers After Swapping using Sum Logic : ");
		Swapping(num1, num2);
		Console.WriteLine("\n");
		Console.WriteLine("Numbers After Swapping using XOR Logic : ");
		SwappingByXOR(num1, num2);
	}	  	
	
	public static void Swapping(int num1, int num2)    
	{	          
  		num1 = num1 + num2;
		num2 = num1 - num2;
		num1 = num1 - num2;
		
		Console.WriteLine(String.Format("Number-1 : {0}, Number-2 : {1}", num1, num2));	
		
	}	
	
	public static void SwappingByXOR(int num1, int num2)    
	{	          
  		num1 = num1 ^ num2;
		num2 = num1 ^ num2;
		num1 = num1 ^ num2;
		
		Console.WriteLine(String.Format("Number-1 : {0}, Number-2 : {1}", num1, num2));	
	}	
}


// Numbers Before Swapping : 
// Number-1 : 10, Number-2 : 20


// Numbers After Swapping using Sum Logic : 
// Number-1 : 20, Number-2 : 10


// Numbers After Swapping using XOR Logic : 
// Number-1 : 20, Number-2 : 10