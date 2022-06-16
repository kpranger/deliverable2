using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
        string input = Console.ReadLine();
        double group = double.Parse(input);
        if (group < 7)
        {
            Console.WriteLine();
            Console.WriteLine("A table for " + group + "! Please follow me and take a seat");
            Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
            int c = 1;
            int numwater = 0;
            int numcoffee = 0;
            while (c <= group)
            {
                Console.WriteLine();
                Console.WriteLine("Alright, person number " + c++ + ", water or coffee?");
                string answer = Console.ReadLine();
                if (answer == "water" || answer == "Water")
                {
                    Console.WriteLine("Water, good choice!");
                    numwater++;
                }
                else if (answer == "coffee" || answer == "Coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    numcoffee++;
                }
                else if (answer != "water" || answer != "coffee")
                {
                    Console.WriteLine("We don't have that. No drink for you!");
                }
            }
            double groupbuffetprice = 9.99 * group;
            double coffeeprice = 2.00 * numcoffee;
            Console.WriteLine();
            Console.WriteLine("Okay, so that's " + numcoffee + " coffees and " + numwater + " waters. I'll be right back. Feel free to grab your food!");
            Console.WriteLine();
            Console.WriteLine("Here's your bill!");
            Console.WriteLine();
            Console.WriteLine(group + " buffets = " + group + " x 9.99 = " + groupbuffetprice);
            Console.WriteLine(numcoffee + " coffees = " + numcoffee + " x 2.00 = " + coffeeprice);
            Console.WriteLine(numwater + " waters = free");
            Console.WriteLine("Total Price = $" + (groupbuffetprice + coffeeprice));
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
        }
    }
}