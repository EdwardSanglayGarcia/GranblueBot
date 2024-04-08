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
            RunningProgram();

            #region Test
            //GetLivePositions();
            //RecoverPots(3);
            #endregion

        }

        static void RunningProgram()
        {
            int summonNumber, runCounter;

            Console.WriteLine($"Input Summon Number:");
            summonNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Input Number Reset");
            runCounter = Convert.ToInt32(Console.ReadLine());
            
            PerformBot(summonNumber, runCounter);
        }

        static void RecoverPots(int numberOfPots)
        {

            Thread.Sleep(2000);

            //Raid
            SimMouse.Click(MouseButtons.Left, 101, 98);
            Thread.Sleep(1500);

            //Potion
            SimMouse.Click(MouseButtons.Left, 236, 153);
            Thread.Sleep(1500);

            //Quantity
            SimMouse.Click(MouseButtons.Left, 295, 547);
            Thread.Sleep(1500);


            int potCoordinateSelection = 548 + (numberOfPots * 20);

            //Selection
            SimMouse.Click(MouseButtons.Left, 320, potCoordinateSelection);
            Thread.Sleep(1500);

            //Use
            SimMouse.Click(MouseButtons.Left, 329, 577);
            Thread.Sleep(1500);

            //OK
            SimMouse.Click(MouseButtons.Left, 261, 588);
            Thread.Sleep(1500);
        }

        static void PerformBot(int summonCount, int botResetCount)
        {
            int numberOfRuns = 1;
            while (true)
            {
                Point mouseObject = Cursor.Position;
                Thread.Sleep(3000);

                //Raid
                SimMouse.Click(MouseButtons.Left, 231, 99);
                Thread.Sleep(2000);

                //Select
                SimMouse.Click(MouseButtons.Left, 254, (summonCount*70)+283);
                Thread.Sleep(2000);

                SimMouse.Click(MouseButtons.Left, 323, 507);
                Thread.Sleep(2700);

                SimMouse.Click(MouseButtons.Left, 254, 355);
                SimMouse.Click(MouseButtons.Left, 254, 355);
                SimMouse.Click(MouseButtons.Left, 254, 355);

                Thread.Sleep(6500);

                SendKeys.SendWait("{F5}");
                Thread.Sleep(2000);

                if (numberOfRuns == botResetCount)
                {
                    numberOfRuns = 1;
                    Thread.Sleep(2000);
                    RecoverPots(Math.Abs(botResetCount / 2) -1);
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
