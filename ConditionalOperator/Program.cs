namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 20;
            string message;
            
            // wersja 1
            
            if (temperature >= 15)
            {
                message = "It's warm outside !";
            }
            else
            {
                message = "It's cold outside !";
            }

            Console.WriteLine(message);
            
            // wersja 2
            
            message = temperature >= 15 ? "It's warm outside !" : "It's cold outside !";

            Console.WriteLine(message);
            
            


        }

        
        

        
    }
};