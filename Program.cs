namespace Csharp_Assignment_1;

class Program
{
    public static void Main(string[] args)
    {
        // ask the user to enter their age
        Console.WriteLine("Please Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // ask the user to insert the needed patient information.
        Console.WriteLine("Please Enter Your Information below:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("SYSTOLIC mm Hg: ");
        int systolic = Convert.ToInt32(Console.ReadLine());

        Console.Write("DIASTOLIC mm Hg: ");
        int diastolic = Convert.ToInt32(Console.ReadLine());


        // create a Patient object
        Patient patient = new Patient(firstName, lastName, weight, height);
        // print out the output
        patient.PrintInfo(systolic, diastolic);
    }
}

