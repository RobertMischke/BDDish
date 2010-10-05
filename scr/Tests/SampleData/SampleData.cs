using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	public class SampleData
	{
		public static IContextDescription OrderA { get { return new SampleOrderA(); } }
		public static IContextDescription OrderB { get { return new SampleOrderB(); } }
	}

}
