using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Invoker
    {
        Queue<ICommand> commandQueue = new Queue<ICommand>();
        Stack<ICommand> commandStack = new Stack<ICommand>();

        public void SetCommand(ICommand command)
        {
            commandQueue.Enqueue(command);
        }

        public void Run()
        {
            while(commandQueue.Count > 0)
            {
                ICommand command = commandQueue.Dequeue(); // получаем первый элемент, который зашел
                command.Execut();
                commandStack.Push(command);
            }
        }

        public void Cancel (int number)
        {
            while (commandStack.Count > 0 && number > 0)
            {
                ICommand command = commandStack.Pop();
                command.Undo();
                number--;
            }
        }

    }
}
