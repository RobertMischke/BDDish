using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
	public class Positions : List<Position>
	{
		public decimal GetTotalPrice()
		{
			return this.Sum(p => p.Preis);
		}

	}
}
