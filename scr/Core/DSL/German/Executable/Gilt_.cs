using System;
using BDDish.DSL;
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
			_modelContext.Add(new Assertion(LabelConcept, asssertionAction, _modelContext));
			return new Gilt_(_modelContext, ParentFür);
		}

        public Gilt_ Gilt(object assertionA, Func<EqualConstraint> equalTo)
        {
            return Gilt(() => assertionA, equalTo);
        }

		public Gilt_ Gilt(Func<object> assertionA, Func<EqualConstraint> equalTo)
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

        public Gilt_ Soll(Action asssertionAction) { return Gilt(asssertionAction); }
        public Gilt_ Soll(object assertion, Func<EqualConstraint> equalTo) { return Gilt(assertion, equalTo); }
        public Gilt_ Soll(Func<object> assertionA, Func<EqualConstraint> equalTo) { return Gilt(assertionA, equalTo); }

        public Gilt_ DannSoll(Action asssertionAction) { return Gilt(asssertionAction); }
        public Gilt_ DannSoll(object assertion, Func<EqualConstraint> equalTo) { return Gilt(assertion, equalTo); }
        public Gilt_ DannSoll(Func<object> assertionA, Func<EqualConstraint> equalTo) { return Gilt(assertionA, equalTo); }

		public Feature Execute()
		{
		    return Execute<Feature>();
		}

        internal override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }


	}
}