using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Common;

namespace Charlotte.Games
{
	public class Game : IDisposable
	{
		public Map Map;

		// <---- prm

		public static Game I = null;

		private Player Player = new Player();

		public Game()
		{
			I = this;
		}

		public void Dispose()
		{
			I = null;
		}

		public void Perform()
		{
			for (; ; )
			{
				// 描画ここから

				this.DrawWall();
				this.DrawMap();
				this.Player.Draw();
				this.DrawEnemies();
				this.DrawWeapons();

				DDEngine.EachFrame();
			}
		}

		private void DrawWall()
		{
			throw new NotImplementedException();
		}

		private void DrawMap()
		{
			throw new NotImplementedException();
		}

		private void DrawEnemies()
		{
			throw new NotImplementedException();
		}

		private void DrawWeapons()
		{
			throw new NotImplementedException();
		}
	}
}
