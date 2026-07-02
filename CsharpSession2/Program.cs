namespace CsharpSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //looping 
            //1- for loop => countable loop
            //2- while loop => uncountable loop

            //For loop:
            //  for( start; end; increment )
            //  {  
            //         some code to be repeated    
            //   }


            int counter = 0;

            for (counter = 10; counter >= 5; counter--)
            {
                Console.WriteLine("certain message loop number:" + counter);

            }
        }
    }
}
