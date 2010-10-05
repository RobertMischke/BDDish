using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
	public class Gilt_
	{
		public const string LabelConcept = "Gilt";

		private readonly Context _modelContext;

		public Gilt_(Context modelContext)
		{
			_modelContext = modelContext;
		}

		public Gilt_ Gilt(object assertionA, EqualConstraint equalTo)
		{
			Assert.That(assertionA, equalTo);

			return new Gilt_(_modelContext);
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			var modelAcceptanceCriterion = new AcceptanceCriterion(German.AkzeptanzKriterium.LabelConcept, beschreibung,
				_modelContext.ParentAceptanceCriterion.ParentCustomer);

			_modelContext.
				ParentAceptanceCriterion.
				ParentCustomer.Add(modelAcceptanceCriterion);

			return new AkzeptanzKriterium(modelAcceptanceCriterion);
		}

		public Kunde Als(ICustomerDescription kundenBeschreibung)
		{
			var modelCustomer = new Customer(Kunde.LabelConcept, kundenBeschreibung,
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