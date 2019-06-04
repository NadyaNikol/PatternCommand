using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            Invoker invoker = new Invoker();
            invoker.SetCommand(new MoveForwardCommand(robot, 29));
            invoker.SetCommand(new RotateCommand(robot, 20));
            invoker.SetCommand(new HandUpCommand(robot, 12));
            invoker.SetCommand(new MoveForwardCommand(robot, -3));

            invoker.Run();

            Console.WriteLine("-----");
            invoker.Cancel(3);
        }
    }
}
