using System;
using System.Collections.Generic;
using System.Threading;


namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.SetWindowSize(80, 25);
			Console.SetBufferSize(80, 25);

			HLine upline = new HLine(0, 78, 0, '+');
			HLine downline = new HLine(0, 78, 23, '+');

			upline.Draw();
			downline.Draw();

			VLine leftline = new VLine(0, 24, 0, '+');
			VLine rigthline = new VLine(0, 24, 78, '+');

			leftline.Draw();
			rigthline.Draw();

			Point p = new Point(4, 7, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);

			snake.Draw();

			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}

				Thread.Sleep(100);
				snake.Move();
			}
		}
	}
}
