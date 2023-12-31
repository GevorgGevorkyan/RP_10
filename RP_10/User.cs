﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_10
{
    internal class User
    {
        public int id;
        public string login;
        public string password;
        public string role;
        public User(int id = 0, string login = "", string password = "", string role = "")
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
        }
    }
    internal class ArrowMenu
    {
        int min, max;
        ConsoleKey keyPressed;
        int markPosition;
        public ArrowMenu(int max, int min = 0)
        {
            this.min = min;
            this.max = max - 1;
        }
        public int Arrows()
        {
            string mark = "->";
            markPosition = min;
            do
            {
                keyPressed = Console.ReadKey(true).Key;
                MenuClear();
                if (keyPressed == (ConsoleKey)KeyBinds.Escape || keyPressed == (ConsoleKey)KeyBinds.F1 || keyPressed == (ConsoleKey)KeyBinds.F2)
                    return markPosition = -444;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    markPosition--;
                    if (markPosition < min)
                        markPosition = max;
                    if (markPosition > max)
                        markPosition = min;
                    Console.SetCursorPosition(0, markPosition);
                    Console.Write(mark);
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    markPosition++;
                    if (markPosition < min)
                        markPosition = max;
                    if (markPosition > max)
                        markPosition = min;
                    Console.SetCursorPosition(0, markPosition);
                    Console.Write(mark);
                }
            }
            while (keyPressed != (ConsoleKey)KeyBinds.Enter);
            Console.Clear();
            return markPosition;
        }
        private void MenuClear()
        {
            Console.SetCursorPosition(0, markPosition);
            Console.Write("  ");
        }
    }
}
