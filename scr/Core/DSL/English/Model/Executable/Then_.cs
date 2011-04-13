using System;
using BDDish.Model.Tree;
using NUnit.Framework.Constraints;
using BDDish.Model;

namespace BDDish.English
{
	public class Then_ : DSLNode
	{
		public const string LabelConcept = "Gilt";

		private readonly Context _modelContext;
		public readonly Given_ ParentGiven;

		public Then_(Context modelContext, Given_ parentGiven) : base(parentGiven)
		{
			_modelContext = modelContext;
			ParentGiven = parentGiven;
		}

		public Then_ Then(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(LabelConcept, asssertionAction, _modelContext));
			return new Then_(_modelContext, ParentGiven);
		}

        public Then_ Then(object assertionA, Func<EqualConstraint> equalTo)
        {
            return Then(() => assertionA, equalTo);
        }

		public Then_ Then(Func<object> assertionA, Func<EqualConstraint> equalTo)
		{
			_modelContext.Add(LabelConcept, assertionA, equalTo);
			return new Then_(_modelContext, ParentGiven);
		}

		public AceptanceCriterion_ AkzeptanzKriterium(string beschreibung)
		{
            var modelAcceptanceCriterion =
                new AcceptanceCriterion(
                    AceptanceCriterion_.LabelConcept,
                    beschreibung,
                    _modelContext.ParentAceptanceCriterion.ParentCustomer
            );

            _modelContext.
                ParentAceptanceCriterion.
                ParentCustomer.Add(modelAcceptanceCriterion);

			return new AceptanceCriterion_(modelAcceptanceCriterion, ParentGiven.ParentAceptanceCriterion.ParentCustomer);
		}

		public Customer_ As(ICustomerDescription kundenBeschreibung)
		{
			var modelCustomer = new Customer(Customer_.LabelConcept, kundenBeschreibung,
			                                 _modelContext.ParentAceptanceCriterion.ParentCustomer.ParentUserStory);

			_modelContext.ParentAceptanceCriterion.
				ParentCustomer.
				ParentUserStory.AddCustomer(modelCustomer);

			return new Customer_(modelCustomer, ParentGiven.
												ParentAceptanceCriterion.
												ParentCustomer.
												ParentRequirement);
		}

        public Feature Execute(object sender)
		{
		    return Execute<Feature>(sender);
		}

        internal override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }
	}
}