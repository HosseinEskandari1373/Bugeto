namespace Practice02_IF_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter a number a week:");
                byte dayOfWeek = byte.Parse(Console.ReadLine());

                if (dayOfWeek == 1)
                {
                    Console.WriteLine("Saturday");
                }
                else if (dayOfWeek == 2)
                {
                    Console.WriteLine("Sunday");
                }
                else if (dayOfWeek == 3)
                {
                    Console.WriteLine("Monday");
                }
                else if (dayOfWeek == 4)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (dayOfWeek == 5)
                {
                    Console.WriteLine("Wensday");
                }
                else if (dayOfWeek == 6)
                {
                    Console.WriteLine("Thersday");
                }
                else if (dayOfWeek == 7)
                {
                    Console.WriteLine("Friday");
                }
                else
                {
                    Console.WriteLine("Please Enter Number as renje 1 to 7!");
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Number as renje 1 to 7!");

                Console.ReadKey();
            }
        }
    }
}