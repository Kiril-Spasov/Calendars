using Calendars;

class Program
{
    static void Main(string[] args)
    {
        YearDate cutoffDay = new YearDate(3, 1);
        YearDate start = new YearDate(8, 15);
        Date birthdate = new Date(2016, new YearDate(2, 29));
        Child schoolChild = new Child("Jill", birthdate);

        SchoolSystem schoolSystem = new SchoolSystem(cutoffDay, 5, start);

        Date beginningSchoolJill = schoolSystem.GetBeginning(schoolChild);

        Console.WriteLine(schoolChild);
        Console.WriteLine("Should begin school on: " + beginningSchoolJill);
        
    }
}
