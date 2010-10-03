using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	public class SampleKunde
	{
		public static ICustomer K1 {get { return new SampleKunde1(); }}
		public static ICustomer K2 { get { return new SampleKunde2(); } }
	}
}
