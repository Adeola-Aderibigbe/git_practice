using System;
using System.ComponentModel.DataAnnotations;


namespace Testrun
{
    class Program
    {
        static void Main()
        {
            //As a bookstore manager, you need to determine the discount for customers based on their total spending.
            // Discounts are applied as follows: no discount for spending less than $50, a 10% discount for spending between $50 and $100, a 15
            // %discount for spending between $100 and $200, and a 20% discount for spending over $200. The final payment is calculated by deducting
            // the discount amount from the total spending.
            Console.Write($"Enter total spending: $");
            double totalSpending = Convert.ToDouble(Console.ReadLine());
            double discount = 0;

            if (totalSpending >= 50 && totalSpending < 100)
            {
                discount = 0.10;
            }
            else if (totalSpending >= 100 && totalSpending < 200)
            {
                discount = 0.15;
            }
            else if (totalSpending > 200)
            {
               discount = 0.20;
            }

            double discountAmount = totalSpending * discount;
            double finalPayment = totalSpending - discount;
            Console.WriteLine($"Discount {discount * 100}%");
            Console.WriteLine($"Discount Amount {discountAmount}");
            Console.WriteLine($"Final Payment {finalPayment}");

        }
    }
}


