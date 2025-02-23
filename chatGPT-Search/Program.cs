namespace chatGPT_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try spicifier example

            int Value1 = 200;
            int Value2 = 22;
            double Value3 = 123.676;
            double Value4 = 20.25;
            int Value5 = 200;

            Console.WriteLine($"{Value1} + {Value2} = {Value1 + Value2:C}");
            Console.WriteLine($"{Value5} / {Value4} = {Value5 / Value4:P}");
            Console.WriteLine($"{Value3} * {Value4} = {Value3 * Value4:N}");


        }
    }
}
