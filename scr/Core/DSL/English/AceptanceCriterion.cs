using System;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.English
{
	public class AceptanceCriterion : DSLNode
	{
		public const string LabelConcept = "AkzeptanzKriterium";

		private readonly AcceptanceCriterion _modelAcceptanceCriterion;
        public readonly Customer_ ParentCustomer;

		public AceptanceCriterion(AcceptanceCriterion modelAcceptanceCriterion, Customer_ parentCustomer) : base(parentCustomer)
		{
			_modelAcceptanceCriterion = modelAcceptanceCriterion;
			ParentCustomer = parentCustomer;
		}

		public Für Für(IContextDescription kontext)
		{
			_modelAcceptanceCriterion.Add(German.Für.LabelConcept, kontext);
			return new Für(_modelAcceptanceCriterion.Context, this);
		}

        public Test_ Test(Action action)
        {
            var assertion = new Assertion(Test_.LabelConcept, action, null);
            _modelAcceptanceCriterion.Add(assertion);
            return new Test_(assertion, this);
        }


        public AceptanceCriterion AkzeptanzKriterium(string beschreibung)
	    {
            var modelAcceptanceCriterion = new AcceptanceCriterion(LabelConcept, beschreibung, _modelAcceptanceCriterion.ParentCustomer );
            _modelAcceptanceCriterion.ParentCustomer.Add(modelAcceptanceCriterion);
            return new AceptanceCriterion(modelAcceptanceCriterion, ParentCustomer);
	    }

        public Feature Execute()
        {
            return Execute<Feature>();
        }

        internal override ConceptNode GetConceptNode()
	    {
	        return _modelAcceptanceCriterion;
	    }

        public AceptanceCriterion Bemerkung(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }

	}
}