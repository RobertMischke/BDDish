﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.DSL;
using BDDish.Model;
using BDDish.Model.Tree;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
    public class Und_ : DSLNode
    {
        public const string LabelConcept = "Und";

        private readonly Context _modelContext;
        public readonly Für ParentFuer;

        public Und_(Context modelContext, Für parentFür)
            : base(parentFür)
        {
            _modelContext = modelContext;
            ParentFuer = parentFür;
        }

        internal override ConceptNode GetConceptNode()
        {
            return _modelContext;
        }

        public Und_ Bemerkung(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }

        public Gilt_ Gilt(Action asssertionAction)
        {
            _modelContext.Add(new Assertion(Gilt_.LabelConcept, asssertionAction, _modelContext));
            return new Gilt_(_modelContext, ParentFuer);
        }

        public Gilt_ Gilt(object assertion, Func<EqualConstraint> equalTo)
        {
            return Gilt(() => assertion, equalTo);
        }

        public Gilt_ Gilt(Func<object> assertionA, Func<EqualConstraint> equalTo)
        {
            _modelContext.Add(LabelConcept, assertionA, equalTo);
            return new Gilt_(_modelContext, ParentFuer);
        }
    }
}