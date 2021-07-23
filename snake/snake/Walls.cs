using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Walls
	{
		List<Figure> WallList;

		public Walls(int Width, int Height)
		{
			WallList = new List<Figure>();

			HLine upline    = new HLine(0, Width-2 , 0       , '+');
			HLine downline  = new HLine(0, Width-2 , Height-1, '+');
			VLine leftline  = new VLine(0, Height-1, 0       , '+');
			VLine rigthline = new VLine(0, Height-1, Width-2 , '+');

			WallList.Add(upline);
			WallList.Add(downline);
			WallList.Add(leftline);
			WallList.Add(rigthline);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in WallList) 
			{
				if (wall.IsHit(figure)) { return true; };
			}

			return false;
		}

		public void Draw()
		{
			foreach (var wall in WallList) 
			{
				wall.Draw();
			}
		}
	}
}
