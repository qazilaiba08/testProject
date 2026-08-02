using System;
using System.Runtime.CompilerServices;

class SubscriptionRenewal
{
    static void Main()
    {
        // Example values - in a real system these would come from the database
        string userName = "Alex";
        int daysUntilExpiration = 5; // number of days left on subscription
        bool isSubscriptionActive = true;

        Console.WriteLine($"Welcome back, {userName}!");

        // Decision statement 1: Check if the subscription is active at all
        if (!isSubscriptionActive)
        {
            Console.WriteLine("Your subscription has expired. Please renew now to continue using the software.");
        }
        else
        {
            // Decision statement 2: Check if it's expiring soon
            if (daysUntilExpiration <= 7)
            {
                // Nested decision: give urgency-based messaging
                if (daysUntilExpiration <= 2)
                {
                    Console.WriteLine($"URGENT: Your subscription expires in {daysUntilExpiration} day(s)! Renew now to avoid interruption.");
                }
                else
                {
                    Console.WriteLine($"Reminder: Your subscription will expire in {daysUntilExpiration} days. Renew soon to keep your access.");
                }
            }
            else
            {
                // Subscription is active and not close to expiring - no message needed
                Console.WriteLine("Your subscription is active. Enjoy the software!");
            }
        }

       string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
        
        Console.WriteLine("\nList of fraudulent order IDs:");
        Console.WriteLine($"1. {fraudulentOrderIDs[0]}");
        Console.WriteLine($"2. {fraudulentOrderIDs[1]}");
        Console.WriteLine($"3. {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "D012"; // Update the first fraudulent order ID
        Console.WriteLine("\nreset the first fraudulent order ID to: " + fraudulentOrderIDs[0]);

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


        string[] names = {"roman", "robim", "jhon"};

        foreach ( string name in names)
        {
            Console.WriteLine(name);
        }

        int[] inventory = {123,453,564,340};
        int sum = 0;
        int bin = 0;

        foreach(int item in inventory)
        {
            sum += item;
            bin++;
            Console.WriteLine($"Item {bin}: {item}");
        }
       Console.WriteLine($"We have {sum} items in inventory.");

       string[] fraudlentOrderIDs = { "A123", "B456", "C789","B234","E3121","F456" };
       foreach(string orderID in fraudlentOrderIDs)
        {
         if (orderID.StartsWith("B"))
        {
          Console.WriteLine($"The order ID starts with 'B'! {orderID}");
         }
        }
    }
}
