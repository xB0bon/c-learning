namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            int pi_1 = Convert.ToInt32(pi); // convert from double (3.14) to int (3)
            

            String x = "true";
            bool y = Convert.ToBoolean(x);
            
            int liczba = 123;
            String text = Convert.ToString(liczba); // convert from int to string
            
            Console.WriteLine(pi_1);
            Console.WriteLine(text);
            Console.WriteLine(y);

        }
    }
};