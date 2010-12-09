using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Concept;

namespace BDDish.German
{
	public class Kunde
	{
		public const string LabelConcept = "Als";

		private readonly Customer _modelCustomer;
		public Anforderung ParentAnforderung;

		public Kunde(Customer modelCustomer, Anforderung parentAnforderung)
		{
			_modelCustomer = modelCustomer;
			ParentAnforderung = parentAnforderung;
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			var modelAcceptanceCriterion = new AcceptanceCriterion(German.AkzeptanzKriterium.LabelConcept , beschreibung, _modelCustomer);
			_modelCustomer.Add(modelAcceptanceCriterion);
			return new AkzeptanzKriterium(modelAcceptanceCriterion, this);
		}
	}
}
