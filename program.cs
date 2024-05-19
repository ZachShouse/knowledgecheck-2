Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<houses>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var houses = new houses();

	Console.WriteLine("Enter the value for ");
	houses = Console.ReadLine();

	recordList.Add(houses);
}

// Print out the list of records using Console.WriteLine()
