namespace Practice02_IF_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DayOfWeek_IF();

            DayOfWeek_Switch();
        }

        public static void DayOfWeek_IF()
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

        public static void DayOfWeek_Switch()
        {
            try
            {
                Console.WriteLine("Please Enter a number: ");
                byte dayOfWeek = byte.Parse(Console.ReadLine());

                switch (dayOfWeek)
                {
                    case 1:
                        Console.WriteLine("Saturday");
                        break;
                    case 2:
                        Console.WriteLine("Sunday");
                        break;
                    case 3:
                        Console.WriteLine("Monday");
                        break;
                    case 4:
                        Console.WriteLine("Tuesday");
                        break;
                    case 5:
                        Console.WriteLine("Wensday");
                        break;
                    case 6:
                        Console.WriteLine("Thursday");
                        break;
                    case 7:
                        Console.WriteLine("Friday");
                        break;
                    default:
                        Console.WriteLine("Please enter number in range 1 to 7");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter number in range 1 to 7");
            }
        }
    }
}
