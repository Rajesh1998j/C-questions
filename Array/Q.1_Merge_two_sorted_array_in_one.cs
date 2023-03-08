// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you merge two sorted arrays into one sorted array? Write a program to merge two sorted arrays.
// Demo		: Merging Two Sorted Arrays

using System;

public class Program
{
	public static void Main()
	{
		int[] firstArray = new int[8];		
		int[] secondArray = new int[4] {5,6,7,8};	
		
		int lastIndex = 4;
		
		for(int i = 0; i <= 3; i++)
		{
			firstArray[i] = i+1;
		}
		
		Console.WriteLine("First Sorted Array: ");	
		Console.WriteLine("---------------------- ");	
		for( int i = 0; i < lastIndex; i++)
		{
			Console.WriteLine(firstArray[i]);
		}
		
		Console.WriteLine("\nSecond Sorted Array: ");	
		Console.WriteLine("---------------------- ");	
		for( int i = 0; i <= secondArray.Length - 1; i++)
		{
			Console.WriteLine(secondArray[i]);
		}
		
		var mergedArray = MergeSortedArrays(firstArray, secondArray, lastIndex);
		
		Console.WriteLine("\nArray After Merging: ");	
		Console.WriteLine("---------------------- ");	
		for( int i = 0; i <= mergedArray.Length - 1; i++)
		{
			Console.WriteLine(mergedArray[i]);
		}
		
	}
	
	 public static int[] MergeSortedArrays(int[] x, int[] y, int lastX)
        {
            int xIndex = lastX;
            int yIndex = y.Length - 1;
            int mergeIndex = x.Length - 1;
		 
            while (yIndex >= 0)
            {
                if (y[yIndex] > x[xIndex])
                {
                    x[mergeIndex] = y[yIndex];
                    yIndex--;
                }
                else if (y[yIndex] < x[xIndex])
                {
                    x[mergeIndex] = x[xIndex];
                    xIndex--;
                }
                mergeIndex--;
            }
            return x;
        }
}

// First Sorted Array: 
// ---------------------- 
// 1
// 2
// 3
// 4

// Second Sorted Array: 
// ---------------------- 
// 5
// 6
// 7
// 8

// Array After Merging: 
// ---------------------- 
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8