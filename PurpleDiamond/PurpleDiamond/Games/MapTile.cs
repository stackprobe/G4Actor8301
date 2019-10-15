using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Common;

namespace Charlotte.Games
{
	public class MapTile
	{
		public const int WH = 32; // タイル(マップセル)の幅と高さ [ピクセル]

		public const int Screen_W = 25; // == DDConsts.Screen_W / WH
		public const int Screen_H = 20; // == DDConsts.Screen_H / WH

		public string Name;
		public DDPicture Picture;

		// <---- prm
	}
}
