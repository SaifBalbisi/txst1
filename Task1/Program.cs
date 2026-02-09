





//
//
/*Write a program that takes the bill amount from the user and calculates the final price after 
applying the discount based on the following conditions: 
• If the bill amount is 500 or more, apply a 20% discount 
• If the bill amount is between 300 and 499, apply a 10% discount 
• If the bill amount is less than 300, no discount is applied 
Finally, print the final price after the discount.*/

Console.WriteLine("pleas Writ bill amount");
double  amount = Convert.ToInt32(Console.ReadLine());
if (amount >= 500)
{
    Console.WriteLine(" 20% discount ");

    amount *= 0.20;
}
else if (amount >= 300 && amount < 400)
{
    Console.WriteLine(" 10% discount ");

    amount *= 0.10;
}
else {
    Console.WriteLine(" no discount is applied ");
}
Console.WriteLine(amount);

