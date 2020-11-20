using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adult = new Adult();
            Child child = new Child();

            string Name[] = {}
            adult.FirstLast();

            child.FirstLasst();




        }
    }


    public class Adult
    {
        public string FName = "Joe";
        public String LName = "Smith";

        public void FirstLast()
        {
         //string First = FName;
         //string Last = LName;

            Console.WriteLine(FName, LName);

        }

    }

    public class Child : Adult
    {
        public string FN = "Jacob";
        public string LN = "Smith";

        public void FirstLasst()
        {
        //string First = FN;
        //string Last = LN;
            Console.WriteLine(FN, LN);

        }
    }
}

    



