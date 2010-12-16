using System;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.German
{
	public class AkzeptanzKriterium_ : Node
	{
		public const string LabelConcept = "AkzeptanzKriterium";

		private readonly AcceptanceCriterion _modelAcceptanceCriterion;

		public Kunde ParentKunde;

		public AkzeptanzKriterium_(AcceptanceCriterion modelAcceptanceCriterion, Kunde parentKunde) : base(parentKunde)
		{
			_modelAcceptanceCriterion = modelAcceptanceCriterion;
			ParentKunde = parentKunde;
		}

		public Für Für(IContextDescription kontext)
		{
			_modelAcceptanceCriterion.AddContext(German.Für.LabelConcept, kontext);
			return new Für(_modelAcceptanceCriterion.Context, this);
		}

        public AkzeptanzKriterium_ AkzeptanzKriterium(string beschreibung)
	    {
	        throw new NotImplementedException();
	    }

	    public Feature Execute()
	    {
	        throw new NotImplementedException();
	    }
	}
}