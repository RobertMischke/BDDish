using System;

namespace BDDish.German
{
	public class AkzeptanzKriterium
	{
		public const string LabelConcept = "AkzeptanzKriterium";

		private readonly AcceptanceCriterion _modelAcceptanceCriterion;

		public AkzeptanzKriterium(AcceptanceCriterion modelAcceptanceCriterion)
		{
			_modelAcceptanceCriterion = modelAcceptanceCriterion;
		}

		public Für Für(IContextDescription kontext)
		{
			_modelAcceptanceCriterion.AddContext(German.Für.LabelConcept, kontext);
			return new Für(_modelAcceptanceCriterion.Context);
		}

	}
}