using System;
using System.ComponentModel.Design;

internal class program;
// As a bookstore manager, you need to determine the discount for customers based on their total spending.
// Discounts are applied as follows: no discount for spending less than $50, a 10% discount for spending between $50 and $100, a 15
// %discount for spending between $100 and $200, and a 20% discount for spending over $200. The final payment is calculated by deducting
// the discount amount from the total spending.
int firstDiscount = 50;
int secondDiscount = 100;
int thirdDiscount = 200;
int discount = ( );
int totalSpending = (firstDiscount + secondDiscount + thirdDiscount);
int finalPayment = (totalSpending - discount);

Console.WriteLine(finalPayment);




