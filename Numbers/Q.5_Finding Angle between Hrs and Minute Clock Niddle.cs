// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you find the angle between the hour and minute needles of a clock at any given time? Write a program for the same.
// Demo		: Finding Angle between Hrs and Minute Clock Niddle

using System;

public class Program
{
	public static void Main()
	{
		int inputHrs = 9;			
		int inputMin = 0;	
		
		Console.WriteLine("Input Time : " + inputHrs + "." + inputMin);	
		Console.WriteLine("Clock Angle : " + AngleInClokTime(inputHrs, inputMin));	
		
	}	  	
	
	public static double AngleInClokTime(int hrs, int mins)    
	{	          
  		 double hourDegrees = (hrs * 30) + (mins * 30.0 / 60);      
		 double minuteDegrees = mins * 6;      
		
		 double difference = Math.Abs(hourDegrees - minuteDegrees);      
		
		 if (difference > 180)      
		 {      
			 difference = 360 - difference;      
		 }      
		
		return difference;
	}	
	
}

// Input Time : 9.0
// Clock Angle : 90