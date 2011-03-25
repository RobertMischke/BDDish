using System;
using BDDish.Model.Tree;
using NUnit.Framework.Constraints;
using BDDish.Model;

namespace BDDish.English
{
	public class Given : DSLNode
	{
		public const string LabelConcept = "Gilt";

		private readonly Context _modelContext;
		public readonly Für ParentFür;

		public Given(Context modelContext, Für parentFür) : base(parentFür)
		{
			_modelContext = modelContext;
			ParentFür = parentFür;
		}

		public Given Gilt(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(LabelConcept, asssertionAction, _modelContext));
			return new Given(_modelContext, ParentFür);
		}

        public Given Gilt(object assertionA, Func<EqualConstraint> equalTo)
        {
            return Gilt(() => assertionA, equalTo);
        }

		public Given Gilt(Func<object> assertionA, Func<EqualConstraint> equalTo)
		{
			_modelContext.Add(LabelConcept, assertionA, equalTo);
			return new Given(_modelContext, ParentFür);
		}

		public AceptanceCriterion AkzeptanzKriterium(string beschreibung)
		{
            var modelAcceptanceCriterion =
                new AcceptanceCriterion(
                    AceptanceCriterion.LabelConcept,
                    beschreibung,
                    _modelContext.ParentAceptanceCriterion.ParentCustomer
            );

            _modelContext.
                ParentAceptanceCriterion.
                ParentCustomer.Add(modelAcceptanceCriterion);

			return new AceptanceCriterion(modelAcceptanceCriterion, ParentFür.ParentAkzeptanzkriterium.ParentCustomer);
		}

		public Customer_ Als(ICustomerDescription kundenBeschreibung)
		{
			var modelCustomer = new Customer(Customer_.LabelConcept, kundenBeschreibung,
			                                 _modelContext.ParentAceptanceCriterion.ParentCustomer.ParentUserStory);

			_modelContext.ParentAceptanceCriterion.
				ParentCustomer.
				ParentUserStory.AddCustomer(modelCustomer);

			return new Customer_(modelCustomer, ParentFür.
												ParentAkzeptanzkriterium.
												ParentCustomer.
												ParentRequirement);
		}

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