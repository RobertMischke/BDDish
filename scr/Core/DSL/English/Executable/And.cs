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
        public readonly Für ParentFuer;

        public And(Context modelContext, Für parentFür)
            : base(parentFür)
        {
            _modelContext = modelContext;
            ParentFuer = parentFür;
        }

        internal override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }

        public And Bemerkung(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }

        public Given Gilt(Action asssertionAction)
        {
            _modelContext.Add(new Assertion(Given.LabelConcept, asssertionAction, _modelContext));
            return new Given(_modelContext, ParentFuer);
        }

        public Given Gilt(object assertion, Func<EqualConstraint> equalTo)
        {
            return Gilt(() => assertion, equalTo);
        }

        public Given Gilt(Func<object> assertionA, Func<EqualConstraint> equalTo)
        {
            _modelContext.Add(LabelConcept, assertionA, equalTo);
            return new Given(_modelContext, ParentFuer);
        }
    }
}
