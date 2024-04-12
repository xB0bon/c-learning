namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            int pi_1 = Convert.ToInt32(pi); // convert from double (3.14) to int (3)
            int liczba = 123;

            String x = "true";
            bool y = Convert.ToBoolean(x);
            
            String text = Convert.ToString(liczba);
            
            Console.WriteLine(pi_1);
            Console.WriteLine(text);
            Console.WriteLine(y);

        }
    }
};