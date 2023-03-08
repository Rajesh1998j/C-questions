// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you rotate an array to the right of a given pivot? Write a program to rotate an array.
// Demo		: Rotating Array

using System;

public class Program
{
	public static void Main()
	{
		int[] array = new int[] {5, 4, 3, 2, 1, 6, 7, 8, 9};							
		int pivot = 3;
		
		Console.WriteLine("Input Array : ");	
		Console.WriteLine("------------------------------------------------ ");	
		
		for( int row = 0; row < array.Length; row++)
		{
			Console.WriteLine(array[row]);
		}	
		
		var rotatedArray =  RotateArray(array, pivot);	
		
		Console.WriteLine(String.Format("\n\nArray After Rotating to Pivote {0} : ", pivot));	
		Console.WriteLine("------------------------------------------------ ");	
		
		for( int row = 0; row < rotatedArray.Length; row++)
		{
			Console.WriteLine(rotatedArray[row]);
		}		
	}		
	
	  public static int[] RotateArray(int[] array, int pivot)
	  {
		  if (pivot < 0 || array == null)
			  throw new Exception("Invalid argument");

		  pivot = pivot % array.Length;

		  //Rotate first half
		  array = RotateSubArray(array, 0, pivot - 1);

		  //Rotate second half
		  array = RotateSubArray(array, pivot, array.Length - 1);

		  //Rotate all
		  array = RotateSubArray(array, 0, array.Length - 1);

		  return array;
	  }

	private static int[] RotateSubArray(int[] subArray, int start, int end)
	{
		while (start < end)
		{
			int temp = subArray[start];
			subArray[start] = subArray[end];
			subArray[end] = temp;
			start++;
			end--;
		}
		return subArray;
	}
	
	// Way 2
	 public static int[] RotateArray2(int[] array, int pivot)
	 {
		  if (pivot < 0 || array == null)
			  throw new Exception("Invalid argument");

		  for(int i = 0; i < pivot; i++)
		  {  
            int j, last;  
          
            last = array[array.Length-1];  
          
            for(j = array.Length-1; j > 0; j--)
			{               
                array[j] = array[j-1];  
            }  
          
            array[0] = last;  
        }  
		return array;
	  }
}

// Input Array : 
// ------------------------------------------------ 
// 5
// 4
// 3
// 2
// 1
// 6
// 7
// 8
// 9


// Array After Rotating to Pivote 3 : 
// ------------------------------------------------ 
// 2
// 1
// 6
// 7
// 8
// 9
// 5
// 4
// 3
// ;