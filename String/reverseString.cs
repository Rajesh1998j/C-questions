// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you reverse a given string without using any library function? Write a program to reverse a given string.
// Demo		: Reverse a string without using any function

using System;
					
public class Program
{
	public static void Main()
	{
		string inputString = "Techamentals";
		string reversedString = ReverseString(inputString);
		
		Console.WriteLine("Input String : " + inputString);
		Console.WriteLine("Reversed String With CharArray Logic: " + reversedString);
		Console.WriteLine("Reversed String With CharArray Logic and Temp Variable: " +  ReverseString2(inputString));
		Console.WriteLine("Reversed String Without CharArray Logic: " +  ReverseString3(inputString));
		
		
	}
	
	static string ReverseString(string inputString)  
	{        
		char[] charArray = inputString.ToCharArray();  
		for (int i = 0, j = inputString.Length - 1; i < j; i++, j--)  
		{  
			charArray[i] = inputString[j];  
			charArray[j] = inputString[i];  
		}  
		string reversedString = new string(charArray);
		return reversedString;		
	}
	
	 public static string ReverseString2(string inputString)
	 {			
		 char[] charArray = inputString.ToCharArray();
		 char temp;
		 for (int j = 0; j < inputString.Length / 2; j++)
         {          
            temp = charArray[j];
            charArray[j] = charArray[charArray.Length - j - 1];
            charArray[charArray.Length - j - 1] = temp;
         }   
		 
		 return  new string(charArray);
	 }
	
	 public static string ReverseString3(string inputString)
	 {
		 string result = "";		

		 for (int i = inputString.Length - 1; i >= 0; i--)
		 {
			 result += inputString[i];
		 }
		 
		 return result;
	 }
	 
}