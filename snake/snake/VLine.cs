using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class VLine : Figure
	{
		public VLine(int yUp, int yDown, int x, char sym)
		{
			pList = new List<Point>();

			for (int y = yUp; y <= yDown; y++)
			{
				pList.Add(new Point(x, y, sym));
			}

		}
	}
}
