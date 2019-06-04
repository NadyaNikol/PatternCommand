using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Robot
    {

        public void MoveForvard(int step)
        {
            if (step > 0)
            {
                Console.WriteLine($"Робот сделал {step} шагов вперед");
            }
            else
            {
                Console.WriteLine($"Робот сделал {-1*step} шагов назад");
            }
        }

        public void Rotate (int degree)
        {
            if (degree > 0)
            {
                Console.WriteLine($"Робот повернулся на  {degree} градусов влево");
            }
            else
            {
                Console.WriteLine($"Робот повернулся на  {-1 * degree} градусов вправо");
            }
        }

        public void HandUp(int sm)
        {
            if (sm > 0)
            {
                Console.WriteLine($"Робот поднял руку на {sm} сантиметров");
            }
            else
            {
                Console.WriteLine($"Робот опустил руку на {-1*sm} сантиметров");
            }
        }

    }
}
