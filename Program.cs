using System;

namespace Lab3RevisedVersionJuly182020
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Y";
            while (input == "Y" || input == "y" || input == "yes")
            {


                bool numIsValid = false;

                Console.WriteLine("What is your first name:  ");
                string name = Console.ReadLine();





                int num = 0;


                while (!numIsValid)

                {
                    Console.WriteLine("Inpt a number between 1-100 ");
                    var numAsString = Console.ReadLine();
                    if (int.TryParse(numAsString, out num))
                    {
                        Console.WriteLine($"The num is: {num}");

                    }
                    else
                    {
                        Console.WriteLine("This is not a valid number!");
                    }

                    if (num > 1 && num < 100)
                    {
                        Console.WriteLine(num);
                        numIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid number");
                        numIsValid = false;
                    }
                }


                if (num % 3 == 0 && num < 60)
                { Console.WriteLine("The number is odd and the number is " + " " + num); }

                else if (num % 2 == 0 && num <= 25)

                { Console.WriteLine("Hey" + " " + name + " " + "The number is even and less than" + " 25." + " " + " The num is " + " " + num); }

                else if (num % 2 == 0 && num <= 60)

                { Console.WriteLine("Hey" + " " + name + " " + "The number is even and the number is" + " " + num); }

                else if (num % 2 == 0 && num > 60)

                { Console.WriteLine("Hey" + " " + name + " " + "The number is even and the number is" + " " + num); }

                else if (num % 3 == 0 && num > 60)

                {
                    Console.WriteLine("Hey" + " " + name + " " + "The number entered is odd and the number is" + " " + num);

                }


                Console.WriteLine("Do you want to continue? Y/N ");

                input = Console.ReadLine();



                if (input == "Y")
                {
                    input = Console.ReadLine().ToLower();
                }
                else if (input == "N")
                {
                    Console.WriteLine("Goodbye");
                }

            }
        }
    }
}
