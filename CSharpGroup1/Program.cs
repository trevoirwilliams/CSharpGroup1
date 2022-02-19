// See https://aka.ms/new-console-template for more information

// Declare global variables for use.
decimal salary = 0.0M;
int numberOfDays = 0;
DateTime employmentDate = DateTime.MinValue;

string[] carsOwned = new string[] { };
List<DateTime> dates = new List<DateTime>();

// try..catch used to try an operation and handle any errors gracefully
try
{
    // prompt for a value and store in variable
    Console.WriteLine("Enter Name: ");
    var name = Console.ReadLine();
    ////PrintName();
    ////name.Append('!');
    ////name.Trim();
    ////name.Trim('-');
    ////name = name.Trim(new char[] { '*', '-', '/', ' ', '.' });
    ////name.EndsWith('s');
    ////name.Split('-');

    // Prompt for a value and store in an interger
    // This value needs to be converted in order to store in an int
    // int.Parse(..) might throw an exception if the inputted value
    // cannot be converted. 
    Console.WriteLine("Enter Your Age: ");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("Employed (true/false): ");
    bool employed = Convert.ToBoolean(Console.ReadLine());

    Console.WriteLine("Enter The Number of Cars You Have Owned: ");
    var numberOfCarsOwned = Convert.ToInt32(Console.ReadLine());

    if (numberOfCarsOwned > 0)
    {
        carsOwned = new string[numberOfCarsOwned];

        for (int i = 0; i < numberOfCarsOwned; i++)
        {
            Console.Write($"Enter The Type Car ({i + 1}): ");
            carsOwned[i] = Console.ReadLine();
        }
    }

    // IF statement checking a boolean before taking action
    if (employed)
    {
        Console.WriteLine("Enter Your Monthly Salary: ");
        salary = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter The Number of Days You Work: ");
        numberOfDays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter The Date You Were Employed (yyyy-mm-dd): ");
        employmentDate = Convert.ToDateTime(Console.ReadLine());
    }

    Console.WriteLine("Name: " + name);
    Console.WriteLine($"Age: {age}");
    Console.WriteLine("Employed: " + employed);

    if (employed)
    {
        // Logic to show the salary as it adds up for each month
        var totalSalary = salary;
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Salary after month {i + 1} is {totalSalary}");
            totalSalary += salary;
        }

        // Potential divide by zero exception
        var dailyRate = DailySalary();
        Console.WriteLine($"Your Daily Salary Rate is: {dailyRate}");
        Console.WriteLine($"Your Employment Date: {employmentDate}");

        for (int i = 0; i < numberOfCarsOwned; i++)
        {
            Console.WriteLine($"Car Owned: " + carsOwned[i]);
        }

        dates[0] = new DateTime();

        dates.Add(new DateTime());
        dates.Remove(new DateTime());
    }
}
catch (Exception ex) // ex is an object that will store the details of any exception that might get thrown
{
    // Print a graceful message to the user without crashing the application
    Console.WriteLine($"{ex.Message}. Please try Again Later.");

    // Use throw when you want to crash the application
    ////throw;
}

var timeStamp = DateTime.Now;

Console.WriteLine($"Time of processing: {timeStamp}");
Console.WriteLine($"UTC Time of processing: {DateTime.UtcNow}");
Console.WriteLine($"Come back in two days: {timeStamp.AddDays(2)}");
Console.WriteLine($"It is the {timeStamp.DayOfYear}th day of the year");

Console.WriteLine("Thank you for your information!");



void PrintName()
{
    Console.WriteLine("I AM The PrintName Method!!");
}

decimal DailySalary()
{
    return salary / numberOfDays;
}