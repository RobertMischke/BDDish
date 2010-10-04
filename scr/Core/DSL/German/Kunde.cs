using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class Kunde
	{
		private readonly Customer _customer;

		public Kunde(Customer customer)
		{
			_customer = customer;
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			throw new NotImplementedException();
		}
	}
}
