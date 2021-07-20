using System;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p = new Point(1, 3, '*');

			p.Draw();

		}

		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
