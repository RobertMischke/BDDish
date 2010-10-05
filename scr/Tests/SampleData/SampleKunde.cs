using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	public class SampleKunde
	{
		public static ICustomerDescription NormalerKunde {get { return new SampleKunde1(); }}
		public static ICustomerDescription Sondermann { get { return new SampleKunde2(); } }
	}
}
