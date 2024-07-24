// See https://aka.ms/new-console-template for more information
using System.Reflection;

namespace TestApp1 {
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (args.Length > 0 && args[0] == "1") {
                CalledIfThingExists();
            }
            else {
                Console.WriteLine("Meowdy!");
            }
        }

        static void CalledIfThingExists() {
            DoSomeTests();
        }
        static void DoSomeTests() {
            Test test = new Test();
            test.Testing();
        }
    }
}


class Test : TestLib1.Class1 {
    public override void Testing()
    {
        base.Testing();
        Console.WriteLine("Testing, testing!");
    }
}