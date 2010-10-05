using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	public class SampleData
	{
		public static IContextDescription A { get { return new SampleDataA(); } }
		public static IContextDescription B { get { return new SampleDataB(); } }
		

	}

}
