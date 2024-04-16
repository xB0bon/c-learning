using System.Reflection.Metadata;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("John", "Json", 30);
            Human human2 = new Human("Jane", "Json", 28);
            
            human1.Welcome();
            human1.Eating();
            human1.Sleeping();
            
            human2.Welcome();
            human2.Eating();
            human2.Sleeping();
            
        }


    }

    class Human
    {
        public String firstname;
        public String lastname ;
        public int age;

        public Human(String firstname, String lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
        public void Welcome()
        {
            Console.WriteLine($"Hi I'm {firstname} {lastname}. I'm {age} years old");
        }

        public void Eating()
        {
            Console.WriteLine($"{firstname} {lastname} is eating...");
        }
        public void Sleeping()
        {
            Console.WriteLine($"{firstname} {lastname} is sleeping...");
        }
    }
};