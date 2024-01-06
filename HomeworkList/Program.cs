
/*
 * Add students to a class roster List
 * until there are no more students.
 * Then print out the count of the 
 * students to the Console.
 */

string answer;
//List<string> student =  new List<string>();
string data = "Mike, Larry, Rob, Jone";
List<string> student = data.Split(',').ToList();

do
{
	//Add students to a class roster List
	Console.WriteLine("Enter student's name to the class roster or else enter no: ");
	answer = Console.ReadLine();
	student.Add(answer);

	
} while ( answer.ToLower() != "no");

// Print out the count of the students to the console
Console.WriteLine($"{student.Count} students are enrolled to the class");