using System; // Importing the base System namespace

namespace PackageExpress // Defining the organizational namespace
{
    class ShippingWizard // Renaming the class for uniqueness
    {
        static void Main(string[] args) // The entry point of the application
        {
            // Requirement 1: The mandatory greeting line
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // --- WEIGHT STAGE ---
            Console.WriteLine("Please enter the package weight:"); // Prompting user for weight
            double weight = Convert.ToDouble(Console.ReadLine()); // Capturing and converting weight to a double

            if (weight > 50) // Checking if the weight exceeds the shipping limit
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); // Rejection message
                return; // Gracefully exiting the application early
            }

            // --- DIMENSIONS STAGE ---
            Console.WriteLine("Please enter the package width:"); // Prompting for width
            double width = Convert.ToDouble(Console.ReadLine()); // Converting input to double

            Console.WriteLine("Please enter the package height:"); // Prompting for height
            double height = Convert.ToDouble(Console.ReadLine()); // Converting input to double

            Console.WriteLine("Please enter the package length:"); // Prompting for length
            double length = Convert.ToDouble(Console.ReadLine()); // Converting input to double

            // Adding dimensions together to check against the size limit
            if ((width + height + length) > 50) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express."); // Error for oversized dimensions
                return; // Ending the program per requirements
            }

            // --- CALCULATION STAGE ---
            // Calculating volume first, then multiplying by weight, then dividing by 100
            double product = (width * height * length) * weight; // Performing the multiplication step
            double quote = product / 100; // Performing the final division step

            // --- OUTPUT STAGE ---
            // Using string interpolation ($) to embed the currency variable directly into the string
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}"); 
            
            Console.WriteLine("Thank you!"); // Mandatory closing courtesy
            
            Console.ReadKey(); // Wait for a final key press so the user can read the quote
        }
    }
}
