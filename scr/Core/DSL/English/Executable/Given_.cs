using System;
using BDDish.Model.Tree;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using BDDish.Model;

namespace BDDish.English
{
	public class Given_ : DSLNode
	{
		public const string LabelConcept = "Für";

		private readonly Context _modelContext;
        public readonly AceptanceCriterion_ ParentAceptanceCriterion;

		public Given_(Context modelContext, AceptanceCriterion_ parentAceptanceCriterion) : base(parentAceptanceCriterion)
		{
			_modelContext = modelContext;
			ParentAceptanceCriterion = parentAceptanceCriterion;
		}

		public Then_ Then(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(English.Then_.LabelConcept, asssertionAction, _modelContext));
			return new Then_(_modelContext, this);
		}

		public Then_ Then(object assertion, Func<EqualConstraint> equalTo)
		{
            return Then(() => assertion, equalTo);
		}

        public Then_ Then(Func<object> assertionA, Func<EqualConstraint> equalTo)
        {
            _modelContext.Add(LabelConcept, assertionA, equalTo);
            return new Then_(_modelContext, this);
        }

        public And And(Action contextAction)
        {
            _modelContext.Add(new ContextSetting(English.And.LabelConcept, contextAction, _modelContext));
            return new And(_modelContext, this);
        }

        internal override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }

        public Given_ Note(string text)
        {
            AddNote(Words.LabelNote, text);
            return this;
        }

	}
}