using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public interface ICommand
    {
         void Execut();
         void Undo();
    }



    public class MoveForwardCommand : ICommand
    {
        Robot receiver;
        int step;
       public MoveForwardCommand(Robot r, int st)
        {
            receiver = r;
            step = st;
        }
        public void Execut()
        {
            receiver.MoveForvard(step);
        }

        public void Undo()
        {
            receiver.MoveForvard(-1 * step);
        }
    }


    public class RotateCommand : ICommand
    {
        Robot receiver;
        int degree;
        public RotateCommand(Robot r, int d)
        {
            receiver = r;
            degree = d;
        }
        public void Execut()
        {
            receiver.Rotate(degree);
        }

        public void Undo()
        {
            receiver.Rotate(-1 * degree);
        }
    }

    public class HandUpCommand : ICommand
    {
        Robot receiver;
        int sm;
        public HandUpCommand(Robot r, int sm)
        {
            receiver = r;
            this.sm = sm;
        }
        public void Execut()
        {
            receiver.HandUp(sm);
        }

        public void Undo()
        {
            receiver.HandUp(-1 * sm);
        }
    }


}



