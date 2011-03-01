using System;
using BDDish.DSL;
using BDDish.Model.Tree;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using BDDish.Model;

namespace BDDish.German
{
	public class Für : DSLNode
	{
		public const string LabelConcept = "Für";

		private readonly Context _modelContext;
        public readonly AkzeptanzKriterium_ ParentAkzeptanzkriterium;

		public Für(Context modelContext, AkzeptanzKriterium_ parentAkzeptanzkriterium) : base(parentAkzeptanzkriterium)
		{
			_modelContext = modelContext;
			ParentAkzeptanzkriterium = parentAkzeptanzkriterium;
		}

		public Gilt_ Gilt(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(Gilt_.LabelConcept, asssertionAction, _modelContext));
			return new Gilt_(_modelContext, this);
		}

		public Gilt_ Gilt(object assertion, Func<EqualConstraint> equalTo)
		{
            return Gilt(() => assertion, equalTo);
		}

        public Gilt_ Gilt(Func<object> assertionA, Func<EqualConstraint> equalTo)
        {
            _modelContext.Add(LabelConcept, assertionA, equalTo);
            return new Gilt_(_modelContext, this);
        }

        public Und_ Und(Action contextAction)
        {
            _modelContext.Add(new ContextSetting(Und_.LabelConcept, contextAction, _modelContext));
            return new Und_(_modelContext, this);
        }

        public Und_ Dann(Action contextAction)
        {
            return Und(contextAction);
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

        public Gilt_ Soll(Action asssertionAction) { return Gilt(asssertionAction); }
        public Gilt_ Soll(object assertion, Func<EqualConstraint> equalTo) { return Gilt(assertion, equalTo); }
        public Gilt_ Soll(Func<object> assertionA, Func<EqualConstraint> equalTo) { return Gilt(assertionA, equalTo); }


	}
}