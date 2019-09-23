using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charlotte.Games
{
	public interface IMap
	{
		MapCell GetCell(int x, int y);
	}
}
