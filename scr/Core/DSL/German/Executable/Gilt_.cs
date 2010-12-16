using System;
using BDDish.Model.Tree;
using NUnit.Framework.Constraints;
using BDDish.Model;

namespace BDDish.German
{
	public class Gilt_ : DSLNode
	{
		public const string LabelConcept = "Gilt";

		private readonly Context _modelContext;
		public readonly Für ParentFür;

		public Gilt_(Context modelContext, Für parentFür) : base(parentFür)
		{
			_modelContext = modelContext;
			ParentFür = parentFür;
		}

		public Gilt_ Gilt(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(LabelConcept, asssertionAction));
			return new Gilt_(_modelContext, ParentFür);
		}

		public Gilt_ Gilt(object assertionA, EqualConstraint equalTo)
		{
			_modelContext.Add(LabelConcept, assertionA, equalTo);
			return new Gilt_(_modelContext, ParentFür);
		}

		public AkzeptanzKriterium_ AkzeptanzKriterium(string beschreibung)
		{
            var modelAcceptanceCriterion =
                new AcceptanceCriterion(
                    AkzeptanzKriterium_.LabelConcept,
                    beschreibung,
                    _modelContext.ParentAceptanceCriterion.ParentCustomer
            );

            _modelContext.
                ParentAceptanceCriterion.
                ParentCustomer.Add(modelAcceptanceCriterion);

			return new AkzeptanzKriterium_(modelAcceptanceCriterion, ParentFür.ParentAkzeptanzkriterium.ParentKunde);
		}

		public Kunde Als(ICustomerDescription kundenBeschreibung)
		{
			var modelCustomer = new Customer(Kunde.LabelConcept, kundenBeschreibung,
			                                 _modelContext.ParentAceptanceCriterion.ParentCustomer.ParentUserStory);

			_modelContext.ParentAceptanceCriterion.
				ParentCustomer.
				ParentUserStory.AddCustomer(modelCustomer);

			return new Kunde(modelCustomer, ParentFür.
												ParentAkzeptanzkriterium.
												ParentKunde.
												ParentAnforderung);
		}

		public Feature Execute()
		{
		    return Execute<Feature>();
		}

        public override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }
	}
}