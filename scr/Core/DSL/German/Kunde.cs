using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.German
{
	public class Kunde : DSLNode
	{
		public const string LabelConcept = "Als";

		private readonly Customer _modelCustomer;
		public Anforderung ParentAnforderung;

		public Kunde(Customer modelCustomer, Anforderung parentAnforderung) : base(parentAnforderung)
		{
			_modelCustomer = modelCustomer;
			ParentAnforderung = parentAnforderung;
		}

		public AkzeptanzKriterium_ AkzeptanzKriterium(string beschreibung)
		{
			var modelAcceptanceCriterion = new AcceptanceCriterion(AkzeptanzKriterium_.LabelConcept , beschreibung, _modelCustomer);
			_modelCustomer.Add(modelAcceptanceCriterion);
			return new AkzeptanzKriterium_(modelAcceptanceCriterion, this);
		}

        public override ConceptNode GetConceptNode()
        {
            return _modelCustomer;
        }
	}
}
