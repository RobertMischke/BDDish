using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Concept;

namespace BDDish.Tests
{
	public class Auftraggeber
	{
		public static ICustomerDescription Normalo {get { return new AuftraggeberNormalo(); }}
		public static ICustomerDescription Sondermann { get { return new AuftraggeberSondermann(); } }
	}
}
