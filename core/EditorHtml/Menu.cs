﻿using System;
namespace EditorHtml
{
	public static class Menu
	{
		public static void Show()
		{
			Console.Clear();

			Console.BackgroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Blue;

			DrawScreen(30,10);
			WriteOptions();

            var option = short.Parse(Console.ReadLine());
            handleMenuOption(option);
        }

		public static void DrawScreen(int columns, int lines)
		{

            DrawHeadEnd(columns);

            for (int i = 0; i <= lines; i++)
			{
                Console.Write("|");
                WriteConsole(columns, " ");

                Console.Write("|");
                Console.Write("\n");
            }

            DrawHeadEnd(columns);

		}

		public static void DrawHeadEnd(int columns)
		{
            Console.Write("+");

            WriteConsole(columns, "-");

            Console.Write("+");
            Console.Write("\n");

        }


		public static void WriteConsole(int quantityItens, string caractere)
		{
            for (int i = 0; i <= quantityItens; i++)
                Console.Write(caractere);
        }

		public static void WriteOptions()
		{
			Console.SetCursorPosition(3, 2);
			Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void handleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}

