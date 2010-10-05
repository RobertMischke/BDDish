using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests.SampleData
{
	public class PositionList : List<Position>
	{
		public decimal GetTotalPrice()
		{
			return this.Sum(p => p.Price);
		}

	}
}
