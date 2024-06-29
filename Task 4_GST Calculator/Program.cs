using System;


namespace Task_4_GST_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {  /* 1. Accept inputs for product name, quantity, cost, and GST inclusion from the user.
              2. Calculate the GST amount based on the user's choice.
              3. Calculate the total cost by adding the product cost and GST amount.
              4. Display the product name, quantity, original cost, GST amount, and total cost.  */

            // Accept inputs from user
            Console.WriteLine("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter Product Quantity: ");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Cost: ");
            double productCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Is GST already included in the cost? (Y/N): ");
            string gstIncluded = Console.ReadLine();

            // Calculate the GST
            double gstRate = 0.15;
            double gstAmount = 0;

            if (gstIncluded.ToUpper() == "Y")
            {
                gstAmount = productCost * gstRate;
            }
            else if (gstIncluded.ToUpper() == "N")
            {
                gstAmount = productCost * gstRate / (1 + gstRate);
            }
            else
            {
                Console.WriteLine("Invalid input for GST inclusion.");
                return;
            }
            // Calculate the total cost
            double totalCost = productCost + gstAmount;

            // Display the results
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product Quantity: " + productQuantity);
            Console.WriteLine("Original Cost: " + productCost);
            Console.WriteLine("GST Amount: " + gstAmount);
            Console.WriteLine("Total Cost with GST: " + totalCost);

            Console.ReadLine();

        }
    }
}
