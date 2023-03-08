// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the third largest element in an array? Write a program to find the 3rd max element in an array.
// Demo		: Third Largest Array Element

using System;

public class Program
{
	public static void Main()
	{
		int[] unsortedArray = new int[8] {5, 3, 6, 2, 1, 4, 8, 7};			
				
		Console.WriteLine("Input UnSorted Array: ");	
		Console.WriteLine("------------------------------------------------ ");	
		for( int i = 0; i < unsortedArray.Length; i++)
		{
			Console.WriteLine(unsortedArray[i]);
		}
		
		Console.WriteLine("\n\nThird Largest Element : " + ThirdLargetElement(unsortedArray));	
		
	}		
		
	static int ThirdLargetElement(int[] array)
	{		
		int large = 0, small = 0, mid = 0;	
	 
		for(int i = 0; i < array.Length; i++) 
		{
				if (large < array[i] && mid <= large)
                {
                    small = mid;
                    mid = large;
                    large = array[i];
                }
                else if (mid < array[i] && small <= mid)
                {
                    small = mid;
                    mid = array[i];
                }
                else if (small <= array[i])
                {
                    small = array[i];
                }
		}
		return small;  
	}	
}


// Input UnSorted Array: 
// ------------------------------------------------ 
// 5
// 3
// 6
// 2
// 1
// 4
// 8
// 7


// Third Largest Element : 6