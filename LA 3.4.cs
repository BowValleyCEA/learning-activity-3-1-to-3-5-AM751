//LA 3.4:

using System;

class ValidAge 

{
    static void Main()
    {
        int age = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine("Enter your age (If you are within 10 years - 50 years) :");

            string input = Console.ReadLine();

            //Try to parse the input to an Integer:

            if (int.TryParse(input, out age))
            {
                //For checking is within the valid range:

                if (age >= 10 && age <= 50)

                {
                    validInput = true;

                    Console.WriteLine("That looks good! You've followed the Criteria and its good to be. Have a Great day ahead.");
                }

                else
                {
                    Console.WriteLine("That dosen't seems good. You must be within 10 years - 50 years.");
                }
            }

            else
            {
                Console.WriteLine("Its an Invalid output. I suggest you to go with an Whole number.");
            }
                          
        }
    }
}