using Calendars;

class Program
{
    static void Demonstrate(Calendar cal)
    {
        SchoolSystem schoolSystem = new SchoolSystem(cal.Create(3, 1), 5, cal.Create(8, 15));

        Child jill = new Child("Jill", cal.Create(1892, 2, 29));
        Child jake = new Child("Jake", cal.Create(1891, 8, 29));

        Console.WriteLine("Using " + cal.GetName() + " calendar.");
        Report(jill, schoolSystem);
        Report(jake, schoolSystem);
        Console.WriteLine();

    }
    static void Report(Child child, SchoolSystem school)
    {
        Console.WriteLine(child + " starts school " + school.GetBeginning(child) + 
            ", celebrates first birthday at school on " + child.GetFirstCelebrationAt(school));
    }
    static void Main(string[] args)
    {
        Demonstrate(new GregorianCalendar());
        Demonstrate(new JulianCalendar());
        
    }
}
