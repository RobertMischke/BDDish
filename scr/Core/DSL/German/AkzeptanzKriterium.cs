using System;
using BDDish.Model.Concept;

namespace BDDish.German
{
	public class AkzeptanzKriterium
	{
		public const string LabelConcept = "AkzeptanzKriterium";

		private readonly AcceptanceCriterion _modelAcceptanceCriterion;

		public Kunde ParentKunde;

		public AkzeptanzKriterium(AcceptanceCriterion modelAcceptanceCriterion, Kunde parentKunde)
		{
			_modelAcceptanceCriterion = modelAcceptanceCriterion;
			ParentKunde = parentKunde;
		}

		public Für Für(IContextDescription kontext)
		{
			_modelAcceptanceCriterion.AddContext(German.Für.LabelConcept, kontext);
			return new Für(_modelAcceptanceCriterion.Context, this);
		}

	}
}