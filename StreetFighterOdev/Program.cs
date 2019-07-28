using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        private const int FIRST_GAMER_STARTUP_POSITION = 10;
        private const int SECOND_GAMER_STARTUP_POSITION = 70;
        private static int Gamer1Point = 0;
        private static int Gamer2Point = 0;
        private const int GameSpeed = 100;

        static void Main(string[] args)
        {

            DrawFirstGamer();

            DrawSecondGamer();

            ShowFirstGamerPoint();

            ShowSecondGamerPoint();

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.RightArrow)
                    GunToSecondGamer();

                if (keyinfo.Key == ConsoleKey.LeftArrow)
                    GunToFirstGamer();

                if (keyinfo.Key == ConsoleKey.DownArrow)
                    GunToSecondGamerKol();

                if (keyinfo.Key == ConsoleKey.UpArrow)
                    GunToFirstGamerKol();

                if (keyinfo.Key == ConsoleKey.W)
                    GunToSecondGamerBacak();

                if (keyinfo.Key == ConsoleKey.S)
                    GunToFirstGamerBacak();


            }
            while (keyinfo.Key != ConsoleKey.X);


            Console.ReadKey();
        }

        public static void DrawFirstGamer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(FIRST_GAMER_STARTUP_POSITION, 3);
            Console.WriteLine(@"    ___      ");
            Console.SetCursorPosition(FIRST_GAMER_STARTUP_POSITION, 4);
            Console.WriteLine(@" __(. .)__");
            Console.SetCursorPosition(FIRST_GAMER_STARTUP_POSITION, 5);
            Console.WriteLine(@"     |       ");
            Console.SetCursorPosition(FIRST_GAMER_STARTUP_POSITION, 6);
            Console.WriteLine(@"     |       ");
            Console.SetCursorPosition(FIRST_GAMER_STARTUP_POSITION, 7);
            Console.WriteLine(@"    | |      ");
            Console.SetCursorPosition(FIRST_GAMER_STARTUP_POSITION, 8);
            Console.WriteLine(@"    / \   ");
        }

        public static void DrawSecondGamer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(SECOND_GAMER_STARTUP_POSITION, 3);
            Console.WriteLine(@"    ___      ");
            Console.SetCursorPosition(SECOND_GAMER_STARTUP_POSITION, 4);
            Console.WriteLine(@" __(. .)__");
            Console.SetCursorPosition(SECOND_GAMER_STARTUP_POSITION, 5);
            Console.WriteLine(@"     |       ");
            Console.SetCursorPosition(SECOND_GAMER_STARTUP_POSITION, 6);
            Console.WriteLine(@"     |       ");
            Console.SetCursorPosition(SECOND_GAMER_STARTUP_POSITION, 7);
            Console.WriteLine(@"    | |      ");
            Console.SetCursorPosition(SECOND_GAMER_STARTUP_POSITION, 8);
            Console.WriteLine(@"    / \  ");
        }

        public static void GunToSecondGamer()
        {
            Thread t = new Thread(() => {

                for (int i = 25; i <= 65; i++)
                {
                    Console.SetCursorPosition(i - 1, 4);
                    Console.Write(" ");


                    Console.SetCursorPosition(i, 4);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("*");
                    Thread.Sleep(GameSpeed);
                }

                Gamer1Point+=10;
                ShowFirstGamerPoint();
            });

            t.Start();
        }

        public static void GunToFirstGamer()
        {
            Thread t = new Thread(() => {
                for (int i = 65; i >= 25; i--)
                {
                    Console.SetCursorPosition(i + 1, 5);
                    Console.Write(" ");


                    Console.SetCursorPosition(i, 5);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("*");
                    Thread.Sleep(GameSpeed);
                }

                Gamer2Point+=10;
                ShowSecondGamerPoint();
            });

            t.Start();

        }



        public static void GunToSecondGamerKol()
        {
            Thread t = new Thread(() => {


              //  Console.SetCursorPosition(70, 8);
                //Console.Write(" ");


                    Console.SetCursorPosition(71, 4);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("|");
                    Thread.Sleep(GameSpeed);

                Gamer1Point+=10;
                ShowSecondGamerPoint();

            });

            t.Start();
        }


        public static void GunToFirstGamerKol()
        {
            Thread t = new Thread(() => {
                
                  //  Console.SetCursorPosition(i, 8);
                    Console.SetCursorPosition(20, 4);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("|");
                    Thread.Sleep(GameSpeed);
                    Gamer2Point++;
                    ShowFirstGamerPoint();



            });

            t.Start();

        }



        public static void GunToSecondGamerBacak()
        {
            Thread t = new Thread(() => {


                    Console.SetCursorPosition(69, 8);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("_____");
                    Thread.Sleep(GameSpeed);

                Gamer2Point++;
                ShowSecondGamerPoint();

            });

            t.Start();
        }


        public static void GunToFirstGamerBacak()
        {
            Thread t = new Thread(() => {
                

                    Console.SetCursorPosition(17, 8);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("____");
                    Thread.Sleep(GameSpeed);
                    Gamer1Point++;
                    ShowFirstGamerPoint();

            });

            t.Start();

        }

        private static void ShowFirstGamerPoint()
        {
            
                    Console.SetCursorPosition(3, 3);
                    Console.WriteLine(Gamer1Point);
                

        }

        private static void ShowSecondGamerPoint()
        {
            Console.SetCursorPosition(78, 3);
            Console.WriteLine(Gamer2Point);

        }
    }
}
