// Author 	: Tech Point Fundamentals
// Website 	: www.techpointfunda.com
// Channel	: https://www.youtube.com/c/TechPointFundamentals
// Question : How can you get the second-highest mark for each student using LINQ?
// Demo		: Finding Second Highest Mark For Each Student

using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
	public int Id {get; set;}
	public string Name {get; set;}
	public string Subject {get; set;}
	public int Marks {get; set;}
}


public class Program
{
	public static void Main()
	{
		List<Student> list = new List<Student>();
		list.Add(new Student{ Id = 1, Name = "Thomas", Subject = "Mathematics", Marks = 80 });
		list.Add(new Student{ Id = 1, Name = "Thomas", Subject = "Science", Marks = 90 });
		list.Add(new Student{ Id = 1, Name = "Thomas", Subject = "History", Marks = 70 });
		list.Add(new Student{ Id = 2, Name = "Peter", Subject = "Mathematics", Marks = 75 });
		list.Add(new Student{ Id = 2, Name = "Peter", Subject = "Science", Marks = 95 });
		list.Add(new Student{ Id = 2, Name = "Peter", Subject = "History", Marks = 85 });
		
		
		Console.WriteLine("Student Marks with Subject : ");	
		Console.WriteLine("-------------------------------------------------------------------");	
		foreach(var student in list)
		{
			Console.WriteLine(String.Format("ID: {0}, NAME: {1}, SUBJECT: {2}, MARKS: {3}", student.Id, student.Name, student.Subject, student.Marks));	
		}		
		
		// Using LINQ 
		var secondHighestMarks = 	  list
									 .GroupBy( r => r.Id)
									 .Select( s => new { 
										 	 	Id = s.Key,
									   		 	Name = s.FirstOrDefault().Name,
									   			Subject = s.FirstOrDefault().Subject,
									   			Marks =  s.OrderByDescending( r => r.Marks).Skip(1).Take(1).FirstOrDefault().Marks
									 });
		
		// Using SQL Like Query
		var secondHighestMarks2 =  from student in list					
								   group student by student.Id into studentGroup								  
								   select new
								   {
									   Id = studentGroup.Key,
									   Name = studentGroup.FirstOrDefault().Name,
									   Subject = studentGroup.FirstOrDefault().Subject,
									   Marks =  studentGroup.OrderByDescending( r => r.Marks).Skip(1).Take(1).FirstOrDefault().Marks
								   }; 
		
		Console.WriteLine("\n\nSecond Highest Mark For Each Student Using LINQ: ");	
		Console.WriteLine("-------------------------------------------------------------------");		
		
		foreach(var student in secondHighestMarks)
		{
			Console.WriteLine(String.Format("ID: {0}, NAME: {1}, SUBJECT: {2}, MARKS: {3}", student.Id, student.Name, student.Subject, student.Marks));	
		}
		
		Console.WriteLine("\n\nSecond Highest Mark For Each Student Using SQL like LINQ: ");	
		Console.WriteLine("-------------------------------------------------------------------");	
		
		foreach(var student in secondHighestMarks2)
		{
			Console.WriteLine(String.Format("ID: {0}, NAME: {1}, SUBJECT: {2}, MARKS: {3}", student.Id, student.Name, student.Subject, student.Marks));	
		}		
	}	
}

// Student Marks with Subject : 
// -------------------------------------------------------------------
// ID: 1, NAME: Thomas, SUBJECT: Mathematics, MARKS: 80
// ID: 1, NAME: Thomas, SUBJECT: Science, MARKS: 90
// ID: 1, NAME: Thomas, SUBJECT: History, MARKS: 70
// ID: 2, NAME: Peter, SUBJECT: Mathematics, MARKS: 75
// ID: 2, NAME: Peter, SUBJECT: Science, MARKS: 95
// ID: 2, NAME: Peter, SUBJECT: History, MARKS: 85


// Second Highest Mark For Each Student Using LINQ: 
// -------------------------------------------------------------------
// ID: 1, NAME: Thomas, SUBJECT: Mathematics, MARKS: 80
// ID: 2, NAME: Peter, SUBJECT: Mathematics, MARKS: 85


// Second Highest Mark For Each Student Using SQL like LINQ: 
// -------------------------------------------------------------------
// ID: 1, NAME: Thomas, SUBJECT: Mathematics, MARKS: 80
// ID: 2, NAME: Peter, SUBJECT: Mathematics, MARKS: 85