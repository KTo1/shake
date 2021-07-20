using System;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p = new Point();
			p.x = 1;
			p.y = 3;
			p.sym = '*';

			p.Draw();

		}

		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
