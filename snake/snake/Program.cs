using System;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Draw(1, 3, '*');
		}

		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
