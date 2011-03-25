using System;
using BDDish.Model.Tree;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using BDDish.Model;

namespace BDDish.English
{
	public class Für : DSLNode
	{
		public const string LabelConcept = "Für";

		private readonly Context _modelContext;
        public readonly AceptanceCriterion ParentAkzeptanzkriterium;

		public Für(Context modelContext, AceptanceCriterion parentAkzeptanzkriterium) : base(parentAkzeptanzkriterium)
		{
			_modelContext = modelContext;
			ParentAkzeptanzkriterium = parentAkzeptanzkriterium;
		}

		public Given Gilt(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(Given.LabelConcept, asssertionAction, _modelContext));
			return new Given(_modelContext, this);
		}

		public Given Gilt(object assertion, Func<EqualConstraint> equalTo)
		{
            return Gilt(() => assertion, equalTo);
		}

        public Given Gilt(Func<object> assertionA, Func<EqualConstraint> equalTo)
        {
            _modelContext.Add(LabelConcept, assertionA, equalTo);
            return new Given(_modelContext, this);
        }

        public And Und(Action contextAction)
        {
            _modelContext.Add(new ContextSetting(And.LabelConcept, contextAction, _modelContext));
            return new And(_modelContext, this);
        }


        internal override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }

        public Für Bemerkung(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }

	}
}