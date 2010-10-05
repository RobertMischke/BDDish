using System;

namespace BDDish.German
{
	public class AkzeptanzKriterium
	{
		private readonly AcceptanceCriterion _modelAcceptanceCriterion;

		public AkzeptanzKriterium(AcceptanceCriterion modelAcceptanceCriterion)
		{
			_modelAcceptanceCriterion = modelAcceptanceCriterion;
		}

		public Für Für(IContextDescription kontext)
		{
			_modelAcceptanceCriterion.AddContext(kontext);
			return new Für(_modelAcceptanceCriterion.Context);
		}

	}
}