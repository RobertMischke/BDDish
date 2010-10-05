using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class Kunde
	{
		public const string LabelConcept = "Als";

		private readonly Customer _modelCustomer;

		public Kunde(Customer modelCustomer)
		{
			_modelCustomer = modelCustomer;
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			var modelAcceptanceCriterion = new AcceptanceCriterion(German.AkzeptanzKriterium.LabelConcept , beschreibung, _modelCustomer);
			_modelCustomer.Add(modelAcceptanceCriterion);
			return new AkzeptanzKriterium(modelAcceptanceCriterion);
		}
	}
}
