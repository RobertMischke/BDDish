using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
	public class Gilt_
	{
		private readonly Context _modelContext;

		public Gilt_(Context modelContext)
		{
			_modelContext = modelContext;
		}

		public Gilt_ Gilt(string assertionA, EqualConstraint equalTo)
		{
			Assert.That(assertionA, equalTo);

			return new Gilt_(_modelContext);
		}

		public Gilt_ Gilt(Action someAssertionMethod, string empty)
		{
			return new Gilt_(_modelContext);
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			var modelAcceptanceCriterion = new AcceptanceCriterion(beschreibung,
			                                                       _modelContext.ParentAceptanceCriterion.ParentCustomer);
			_modelContext.
				ParentAceptanceCriterion.
				ParentCustomer.Add(modelAcceptanceCriterion);

			return new AkzeptanzKriterium(modelAcceptanceCriterion);
		}

		public Kunde Als(ICustomerDescription kundenBeschreibung)
		{
			var modelCustomer = new Customer(kundenBeschreibung,
			                                 _modelContext.ParentAceptanceCriterion.ParentCustomer.ParentUserStory);

			_modelContext.ParentAceptanceCriterion.
				ParentCustomer.
				ParentUserStory.AddCustomer(modelCustomer);

			return new Kunde(modelCustomer);
		}

		public void Execute()
		{
			new ModelExecuter()
				.Run(_modelContext.
						ParentAceptanceCriterion.
						ParentCustomer.
						ParentUserStory.
						ParentFeature);
		}
	}
}