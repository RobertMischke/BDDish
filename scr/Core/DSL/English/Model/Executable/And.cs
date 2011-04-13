using System;
using BDDish.Model;
using BDDish.Model.Tree;
using NUnit.Framework.Constraints;

namespace BDDish.English
{
    public class And : DSLNode
    {
        public const string LabelConcept = "Und";

        private readonly Context _modelContext;
        public readonly Given_ ParentFuer;

        public And(Context modelContext, Given_ parentGiven)
            : base(parentGiven)
        {
            _modelContext = modelContext;
            ParentFuer = parentGiven;
        }

        internal override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }

        public And Note(string text)
        {
            AddNote(Words.LabelNote, text);
            return this;
        }

        public Then_ Then(Action asssertionAction)
        {
            _modelContext.Add(new Assertion(Then_.LabelConcept, asssertionAction, _modelContext));
            return new Then_(_modelContext, ParentFuer);
        }

        public Then_ Then(object assertion, Func<EqualConstraint> equalTo)
        {
            return Then(() => assertion, equalTo);
        }

        public Then_ Then(Func<object> assertionA, Func<EqualConstraint> equalTo)
        {
            _modelContext.Add(LabelConcept, assertionA, equalTo);
            return new Then_(_modelContext, ParentFuer);
        }
    }
}
