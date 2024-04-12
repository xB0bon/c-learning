namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = "John Json";
            String firstname = fullname.Substring(0, 4);
            String lastname = fullname.Substring(5);
            String phoneNumber = "123-456-7890";

            phoneNumber = phoneNumber.Replace("-", "");
            
            //fullname = fullname.ToUpper(); // JOHN JSON
            //fullname = fullname.ToLower(); // john json

            Console.WriteLine(fullname);
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(phoneNumber);
            
            
        }
    }
};