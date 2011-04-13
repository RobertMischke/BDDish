using System;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.German
{
	public class AkzeptanzKriterium_ : DSLNode
	{
		public const string LabelConcept = "AkzeptanzKriterium";

		private readonly AcceptanceCriterion _modelAcceptanceCriterion;
        public readonly Kunde ParentKunde;

		public AkzeptanzKriterium_(AcceptanceCriterion modelAcceptanceCriterion, Kunde parentKunde) : base(parentKunde)
		{
			_modelAcceptanceCriterion = modelAcceptanceCriterion;
			ParentKunde = parentKunde;
		}

        public Für GegebenIst(Func<IContextDescription> kontext){ return Für(kontext); }
        public Für GegebenIst(IContextDescription kontext) { return Für(kontext); }
        
        public Für GegebenSind(Func<IContextDescription> kontext) { return Für(kontext); }
        public Für GegebenSind(IContextDescription kontext) { return Für(kontext); }

        public Für Wenn(Func<IContextDescription> kontext){ return Für(kontext); }
        public Für Wenn(IContextDescription kontext) { return Für(kontext); }

		public Für Für(Func<IContextDescription> kontext){return Für(kontext.Invoke());}
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


        public AkzeptanzKriterium_ AkzeptanzKriterium(string beschreibung)
	    {
            var modelAcceptanceCriterion = new AcceptanceCriterion(LabelConcept, beschreibung, _modelAcceptanceCriterion.ParentCustomer );
            _modelAcceptanceCriterion.ParentCustomer.Add(modelAcceptanceCriterion);
            return new AkzeptanzKriterium_(modelAcceptanceCriterion, ParentKunde);
	    }

        public Feature Execute(object sender)
        {
            return Execute<Feature>(sender);
        }

        internal override ConceptNode GetConceptNode()
	    {
	        return _modelAcceptanceCriterion;
	    }

        public AkzeptanzKriterium_ Bemerkung(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }
	}
}