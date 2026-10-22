namespace ConsoleApp2
{ 
        internal class Program
        {
            static void Main2(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }


        public class Program2
        {
            static void Main()
            {
                Console.WriteLine("Hello World 2!");

                Person.showHistory();

                Person PersonA = new Person();
                PersonA.sleep();

            }
        }

    class Person
    {
        public static void showHistory()
        {
            Console.WriteLine("Human history begin at ...");
            Console.WriteLine("Then ... The End");
        }
        public void sleep()
        {
            Console.WriteLine("Im sleeping!!");
        }

    }

    }
