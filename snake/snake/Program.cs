using System;
using System.Collections.Generic;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p = new Point(1, 3, '*');

			p.Draw();

			HLine line = new HLine(1, 20, 3, '*');
			line.Draw();

		}

		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
