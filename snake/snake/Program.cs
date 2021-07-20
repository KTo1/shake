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

			List<int> numList = new List<int>();

			numList.Add(0);
			numList.Add(1);
			numList.Add(2);

			foreach (int i in numList)
			{
				Console.WriteLine(i);
			}

			numList.RemoveAt(0);

			List<Point> pList = new List<Point>();

			pList.Add(p);

		}

		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
