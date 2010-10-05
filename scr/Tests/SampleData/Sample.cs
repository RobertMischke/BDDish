using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	public class Sample
	{
		public static IContextDescription Order3Positions { get { return new Order3Positions(); } }
		public static IContextDescription Order1Position { get { return new Order1Position(); } }
	}

}
