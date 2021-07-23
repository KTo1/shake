using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class HLine : Figure
	{

		public HLine(int xLeft, int xRigth, int y, char sym)
		{
			pList = new List<Point>();

			for (int x = xLeft; x <= xRigth; x++)
			{
				pList.Add(new Point(x, y, sym));
			}

		}
	}
}
