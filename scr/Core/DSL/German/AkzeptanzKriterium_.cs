using System;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.German
{
	public class AkzeptanzKriterium_ : DSLNode
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
            var modelAcceptanceCriterion = new AcceptanceCriterion(LabelConcept, beschreibung, _modelAcceptanceCriterion.ParentCustomer );
            _modelAcceptanceCriterion.ParentCustomer.Add(modelAcceptanceCriterion);
            return new AkzeptanzKriterium_(modelAcceptanceCriterion, ParentKunde);
	    }

        public Feature Execute()
        {
            return Execute<Feature>();
        }

	    public override ConceptNode GetConceptNode()
	    {
	        return _modelAcceptanceCriterion;
	    }
	}
}