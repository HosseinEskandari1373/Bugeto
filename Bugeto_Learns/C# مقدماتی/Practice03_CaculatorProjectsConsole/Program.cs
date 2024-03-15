namespace Practice03_CaculatorProjectsConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Be Mashin Hesab Khosh Amadid!");

            bool IsWhile = true;
            while (IsWhile)
            {
                Console.WriteLine("Please Enter Num1:");
                int Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Num2:");
                int Num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Lotfan Operation Ra Entekhab Konid:");
                Console.WriteLine("a = +");
                Console.WriteLine("m = *");
                Console.WriteLine("d = /");
                Console.WriteLine("s = -");

                Console.WriteLine("Lotfan harf amaliat khod ra vared nemaeid:");
                string Operation = Console.ReadLine();

                switch (Operation)
                {
                    case "a":
                        Console.WriteLine($"{Num1} + {Num2} = " + (Num1 + Num2));
                        break;
                    case "m":
                        Console.WriteLine($"{Num1} * {Num2} = " + (Num1 * Num2));
                        break;
                    case "d":
                        Console.WriteLine($"{Num1} / {Num2} = " + (Num1 / Num2));
                        break;
                    case "s":
                        Console.WriteLine($"{Num1} - {Num2} = " + (Num1 - Num2));
                        break;
                    default:
                        Console.WriteLine("Lotfan yek amaliat ra vard konid");
                        break;
                }

                Console.WriteLine("Baraye Khoroj close ra vard nemaeid:");

                if (Console.ReadLine() == "close")
                {
                    IsWhile = false;
                }
            }
        }
    }
}
