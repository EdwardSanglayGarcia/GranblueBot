using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using SimWinInput;
using System.Threading;

namespace MouseClickerConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xCoordinate, yCoordinate, runCounter;

            Console.Clear();
            Console.WriteLine($"Summon 1 - [254,355]\nSummon 2 - [254,421]\nSummon 3 - [254,502]\nSummon 4 - [249,586]\n");
            Console.WriteLine($"Input X Coordinate:");
            xCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input Y Coordinate:");
            yCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input Number Reset");
            runCounter = Convert.ToInt32(Console.ReadLine());

            PerformBot(xCoordinate, yCoordinate, runCounter);


            #region Test
            //GetLivePositions();
            //RecoverPots();
            #endregion

        }

        static void RecoverPots()
        {
            Thread.Sleep(2000);

            SimMouse.Click(MouseButtons.Left, 101, 98);
            Thread.Sleep(4000);

            SimMouse.Click(MouseButtons.Left, 228, 152);
            Thread.Sleep(4000);

            SimMouse.Click(MouseButtons.Left, 316, 569);
            Thread.Sleep(4000);

            SimMouse.Click(MouseButtons.Left, 321, 626);
            Thread.Sleep(4000);

            SimMouse.Click(MouseButtons.Left, 326, 602);
            Thread.Sleep(4000);

            SimMouse.Click(MouseButtons.Left, 268, 590);
            Thread.Sleep(2000);
        }

        static void PerformBot(int xValue, int yValue, int botResetCount)
        {
            int numberOfRuns = 1;
            while (true)
            {
                Point mouseObject = Cursor.Position;
                Thread.Sleep(3000);

                SimMouse.Click(MouseButtons.Left, 231, 99);
                Thread.Sleep(2000);

                SimMouse.Click(MouseButtons.Left, xValue, yValue);
                Thread.Sleep(2000);

                SimMouse.Click(MouseButtons.Left, 323, 507);
                Thread.Sleep(2700);

                SimMouse.Click(MouseButtons.Left, 254, 355);
                SimMouse.Click(MouseButtons.Left, 254, 355);
                SimMouse.Click(MouseButtons.Left, 254, 355);

                Thread.Sleep(7000);

                SendKeys.SendWait("{F5}");
                Thread.Sleep(2000);

                if (numberOfRuns == botResetCount)
                {
                    numberOfRuns = 1;
                    Thread.Sleep(2000);
                    RecoverPots();
                }

                numberOfRuns++;
            }

        }

        static void GetLivePositions()
        {
            Point mouseObject = Cursor.Position;
            //current starting position
            int positionX = mouseObject.X;
            int positionY = mouseObject.Y;

            while (true)
            {
                mouseObject = Cursor.Position;
                if (positionX != mouseObject.X && positionY != mouseObject.Y)
                {
                    positionX = mouseObject.X;
                    positionY = mouseObject.Y;
                    Console.WriteLine($"{mouseObject.X},{mouseObject.Y}");
                }
            }

        }
    }
}
