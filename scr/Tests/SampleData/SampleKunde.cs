using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	public class SampleKunde
	{
		public static ICustomer NormalerKunde {get { return new SampleKunde1(); }}
		public static ICustomer Sondermann { get { return new SampleKunde2(); } }
	}
}
