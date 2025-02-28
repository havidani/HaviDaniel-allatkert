using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02282
{
	internal class Tropusiallatok
	{
		private string nev;
		private int sebesseg;

		public Tropusiallatok(string nev, int sebesseg)
		{
			this.nev = nev;
			this.sebesseg = sebesseg;
		}

		public string Nev
		{
			get { return nev; }
		}

		public int Sebesseg
		{
			get { return sebesseg; }
		}

		public override string ToString()
		{
			return $"Név: {nev}, Sebesség: {sebesseg}";
		}
	}
}
