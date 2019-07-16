
using DataStructuresLibrary;
using static System.Console;

namespace DataStructuresConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddHead(2);
            list.AddHead(1);
            list.AddTail(3);
            list.AddTail(4);
            list.AddTail(5);

            foreach(var i in list)
            {
                WriteLine(i);
            }
        }
    }
}
