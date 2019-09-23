using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;
using Charlotte.Common;

namespace Charlotte.Games
{
	public class Map
	{
		private DDTable<MapCell> Table;

		public Map(int w, int h)
		{
			this.Table = new DDTable<MapCell>(w, h, (x, y) => new MapCell());
		}

		public int W { get { return this.Table.W; } }
		public int H { get { return this.Table.H; } }

		private MapCell DefaultCell = new MapCell();

		public MapCell GetCell(int x, int y)
		{
			return this.Table.GetCell(x, y, this.DefaultCell);
		}

		private Dictionary<string, string> Properties = DictionaryTools.Create<string>();

		public void AddProperty(string name, string value)
		{
			this.Properties.Add(name, value);
		}

		public string GetProperty(string name, string defval = null)
		{
			if (this.Properties.ContainsKey(name) == false)
				return defval;

			return this.Properties[name];
		}

		public IEnumerable<KeyValuePair<string, string>> GetProperties()
		{
			return this.Properties;
		}
	}
}
