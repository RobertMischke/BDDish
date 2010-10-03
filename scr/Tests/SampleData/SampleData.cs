using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	public class SampleData
	{
		public static IContext A { get { return new SampleDataA(); } }
		public static IContext B { get { return new SampleDataB(); } }
		

	}

}
