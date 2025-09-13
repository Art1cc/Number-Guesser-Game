namespace Random_Number_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool guessed = false;
            bool invalid_input = false;
            int lower_lim;
            int upper_lim;
        
            do
            {
                Console.WriteLine("Welcome to the random number generator. Enter the lower limit.");
                lower_lim = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the upper limit");
                upper_lim = int.Parse(Console.ReadLine());

                if(lower_lim >= upper_lim)
                {
                    Console.WriteLine("Lower limit cannot be greater than or equal to the upper limit. Try again.");
                    invalid_input = true;
                    Console.ReadLine();
                    Console.Clear();
                }
                
                if (upper_lim > lower_lim)
                {
                    invalid_input = false;
                    Console.Clear();
                    break;

                }
            } while (invalid_input == true);

            Random random = new Random();
            int randomnumber = random.Next(lower_lim, upper_lim);
           
                do
                {
                    Console.WriteLine("Enter a valid number. You can press 'Q' at any time to quit the game.");
                    int number = int.Parse(Console.ReadLine());
               
                    while (number > 0)
                    {
                        if (number == randomnumber )
                        {
                            Console.WriteLine($"Well done! The correct number was {randomnumber}"); 
                            guessed = true;
                        break;
                        }
                        
                        if (number != randomnumber)
                        {
                            Console.WriteLine("Incorrect number. Try again");
                            guessed = false;
                        break;
                        }
                    }
                    if (number <= 0 || number <lower_lim || number> upper_lim)
                    {
                        Console.WriteLine("Number cannot be negative or equal to 0. It can't be lower than the lower limit or higher than the upper limit.Try again");
                        guessed = false;
                    Console.ReadLine();
                    Console.Clear();
                }
                   
            } while (guessed != true);
           
            Console.ReadLine();
        }
    }
}
