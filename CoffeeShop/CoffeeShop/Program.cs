using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Program
    {
        static void Main(string[] args)
        {

            int UserChoice = 0;
            var CoffeeCost = 0;
            string UserDecision = string.Empty;
            do
            {


                do
                {
                    Console.WriteLine("Please select your coffee size : 1 - Small, 2 - Medium, 3 - Large");
                    UserChoice = int.Parse(Console.ReadLine());
                    //TODO exception handling
                    try
                    {
                        switch (UserChoice)
                    {
                        case 1:
                            CoffeeCost += 1;
                            break;
                        case 2:
                            CoffeeCost += 2;
                            break;
                        case 3:
                            CoffeeCost += 3;
                            break;
                        default:
                            throw new Exception();
                    }

                    }catch(Exception ex)
                    {
                        Console.WriteLine("Your choice is invalid.Please try again...");
                    }
                    

                } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

                do
                {


                    Console.WriteLine("Do you want to buy another coffee? - Yes or No");
                    //upper case?
                    UserDecision = Console.ReadLine();
                    //TODO exception handling
                    try
                    {
                        if (UserDecision != "Yes" && UserDecision != "No")
                         {
                            throw new Exception();
                          }

                    }catch(Exception ex)
                    {
                        Console.WriteLine("Your choice {0} is invalid.Please try again...");
                    }
                    
                } while (UserDecision != "Yes" && UserDecision != "No");
            } while (UserDecision != "No");
            Console.WriteLine("Thank you for shoping with us.\nBill amonut is {0}", CoffeeCost);
        }
    }
}
