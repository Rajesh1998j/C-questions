// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : Write a program to find the sum of the diagonal of a 2D array?
// Demo		: Sum of the 2D Array Diagonal

using System;

public class Program
{
	public static void Main()
	{
		int[,] array = {
							{1, 6, 3, 2, 5},
							{2, 7, 2, 8, 7},
							{3, 8, 1, 6, 4},
							{4, 9, 0, 5, 0},
							{5, 4, 7, 3, 9}
						};			
				
		 int rowlength = 	array.GetLength(0);
         int columnLength = array.GetLength(1);
		
		Console.WriteLine("Input 2D Array : ");	
		Console.WriteLine("------------------------------------------------ ");	
		
		for( int row = 0; row < rowlength; row++)
		{
			for( int col = 0; col < columnLength; col++)
			{
				Console.Write(array[row,col] +  " ");
			}
			Console.WriteLine();
		}	
		
		ArrayDiagonal(array, rowlength, columnLength);					
	}	
	
	public static void ArrayDiagonal(int[,] array, int rowLength, int colLength)    
	{     
		int sum = 0;
		
		Console.WriteLine("\n\nDiagonal Array Element: ");	
		Console.WriteLine("------------------------------------------------ ");	
		
		for(int row = 0; row < rowLength; row++)
		{ 
			for(int column = 0; column < colLength; column++)
			{
				Console.Write("  ");
				if(row == column)
				{
					Console.Write( array[row,column] + " ");
					sum += array[row,column];
				}
			}
			Console.WriteLine();
		}
		
		Console.WriteLine("\n\nDiagonal Array Element Sum : " + sum);		
	} 	
}

// Input 2D Array : 
// ------------------------------------------------ 
// 1 6 3 2 5 
// 2 7 2 8 7 
// 3 8 1 6 4 
// 4 9 0 5 0 
// 5 4 7 3 9 


// Diagonal Array Element: 
// ------------------------------------------------ 
//   1         
//     7       
//       1     
//         5   
//           9 


// Diagonal Array Element Sum : 23