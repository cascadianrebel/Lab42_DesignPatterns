using Lab42_DesignPatterns.ConcreteCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to Build Resume");
            Console.ReadKey();

            Document[] documents = new Document[2];

            documents[0] = new Resume();


            Console.WriteLine("Press Enter to Build a Cover Letter");
            Console.ReadKey();
            documents[1] = new CoverLetter();



            Console.Read();
        }
    }
}
