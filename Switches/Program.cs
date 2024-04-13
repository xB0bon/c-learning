namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaki jest dzień tygodnia?");
            String day = Console.ReadLine() ?? "";

            switch (day.ToLower())
            {
                case "poniedziałek":
                    Console.WriteLine("Dziś jest Poniedziałek");
                    break;
                case "wtorek":
                    Console.WriteLine("Dziś jest Wtorek");
                    break;
                case "środa":
                    Console.WriteLine("Dziś jest środa");
                    break;
                case "czwartek":
                    Console.WriteLine("Dziś jest czwartek");
                    break;
                case "piątek":
                    Console.WriteLine("Dziś jest piątek");
                    break;
                case "sobota":
                    Console.WriteLine("Dziś jest sobota");
                    break;
                case "niedziela":
                    Console.WriteLine("Dziś jest niedziela");
                    break;
                default:
                    Console.WriteLine(day + " nie jest dniem tygodnia!");
                    break;
                
                
            }
            {
                
            }
        }
    }
};