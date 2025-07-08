/*
Write a C# Sharp program to accept two integers and check whether they are equal or not.

Test Data :
    Input 1st number: 5
    Input 2nd number: 5
Expected Output :
    5 and 5 are equal

Test Data :
    Input 1st number: 5
    Input 2nd number: 15
Expected Output :
    5 and 15 are not equal
*/

namespace Assignment_1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks if two integers are equal.");
            Console.Write("Input 1st integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " are equal");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are not equal");
            }
        }
    }
}
