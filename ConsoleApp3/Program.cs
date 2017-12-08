using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

// чтобы справиться с домашкой я перепрохожу основы. постепенно наверстаю, все сделаю!
// весь код который идет ниже пока что можно не читать, это тренировка.

namespace ConsoleApp3
{
	class Program
	{

        static void DrawFlower(int angle, int times)
        {
            int i;
            for (i = 0; i < times; i++)
            {
                Turtle.Move(100);
                Turtle.Turn(angle);
            }

        }

        static void Main(string[] args)
		{
            Turtle.Speed = 9;
            
            DrawFlower(160, 9);

            Turtle.PenUp();
            Turtle.MoveTo(150, 300);
            Turtle.PenDown();
            Turtle.PenDown();

            DrawFlower(170, 12);

            Turtle.PenUp();
            Turtle.MoveTo(480, 260);
            Turtle.PenDown();


            DrawFlower(100, 18);
            Turtle.Hide();
        }

    }
}
