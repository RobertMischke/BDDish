using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class Kunde
	{
		private readonly Customer _modelCustomer;

		public Kunde(Customer modelCustomer)
		{
			_modelCustomer = modelCustomer;
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			var modelAcceptanceCriterion = new AcceptanceCriterion(_modelCustomer, beschreibung);
			_modelCustomer.Add(modelAcceptanceCriterion);
			return new AkzeptanzKriterium(modelAcceptanceCriterion);
		}
	}
}
