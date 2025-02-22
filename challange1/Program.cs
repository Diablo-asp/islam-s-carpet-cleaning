namespace challange1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Name  
              Console.WriteLine("Hello User");
              Console.WriteLine("What's you'r name?");
            string name = Console.ReadLine();
              Console.WriteLine("Hello " + name);

          // age
              Console.WriteLine("how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("ummm i wish you a long life");


          // Fav Numper
              Console.WriteLine("pleas, Inter you'r Fav. Numper betwen 1:100");
              int theNumper = Convert.ToInt32(Console.ReadLine());
            if (theNumper > 100 || theNumper < 1)
            { Console.WriteLine(theNumper + " is not betwen 1:100"); }
            else
            {
                Console.WriteLine($"Really! {theNumper} is my Fav numper too");
            }


        }
    }
}
