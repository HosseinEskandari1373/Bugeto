namespace Practice01_GetInput_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Num1:");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Num2:");
            int Num2 = int.Parse(Console.ReadLine());

            int Sum = Num1 + Num2;
            //Console.WriteLine($"Sum is: {Sum}");
            Console.WriteLine("Sum is:" + " " +  Sum);

            Console.ReadKey();
        }
    }
}
