using System;
using BDDish.DSL;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.English
{
	public class AceptanceCriterion_ : DSLNode
	{
		public const string LabelConcept = "AkzeptanzKriterium";

		private readonly AcceptanceCriterion _modelAcceptanceCriterion;
        public readonly Customer_ ParentCustomer;

		public AceptanceCriterion_(AcceptanceCriterion modelAcceptanceCriterion, Customer_ parentCustomer) : base(parentCustomer)
		{
			_modelAcceptanceCriterion = modelAcceptanceCriterion;
			ParentCustomer = parentCustomer;
		}

        public Given_ When(Func<IContextDescription> someContext) { return Given(someContext.Invoke()); }
        public Given_ When(IContextDescription someContext) { return Given(someContext); }

        public Given_ Given(Func<IContextDescription> someContext) { return Given(someContext.Invoke()); }
		public Given_ Given(IContextDescription kontext)
		{
			_modelAcceptanceCriterion.Add(German.Für.LabelConcept, kontext);
			return new Given_(_modelAcceptanceCriterion.Context, this);
		}

        public Test_ Test(Action action)
        {
            var assertion = new Assertion(Test_.LabelConcept, action, null);
            _modelAcceptanceCriterion.Add(assertion);
            return new Test_(assertion, this);
        }


        public AceptanceCriterion_ AceptanceCriterion(string beschreibung)
	    {
            var modelAcceptanceCriterion = new AcceptanceCriterion(LabelConcept, beschreibung, _modelAcceptanceCriterion.ParentCustomer );
            _modelAcceptanceCriterion.ParentCustomer.Add(modelAcceptanceCriterion);
            return new AceptanceCriterion_(modelAcceptanceCriterion, ParentCustomer);
	    }

        public Feature Execute(object sender)
        {
            return Execute<Feature>(sender);
        }

        internal override ConceptNode GetConceptNode()
	    {
	        return _modelAcceptanceCriterion;
	    }

        public AceptanceCriterion_ Note(string text)
        {
            AddNote(Words.LabelNote, text);
            return this;
        }
	}
}