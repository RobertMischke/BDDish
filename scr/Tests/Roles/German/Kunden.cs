using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests
{
	/// <summary>
	/// Kunden die die Software kaufen und beauftragen.
	/// </summary>
	public class Kunden
	{
		public static ICustomerDescription Normalo {get { return new KundeNormalo(); }}
		public static ICustomerDescription Sondermann { get { return new KundeSondernmann(); } }
	}
}
