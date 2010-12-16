using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.German
{
    public class Test_ : DSLNode
    {
        public const string LabelConcept = "Test";

        private readonly Assertion _modelAssertion;
        public readonly AkzeptanzKriterium_ ParentAkzeptanzkriterium;

        public Test_(Assertion modelAssertion, AkzeptanzKriterium_ parentAkzeptanzkriterium)
            : base(parentAkzeptanzkriterium)
        {
            _modelAssertion = modelAssertion;
            ParentAkzeptanzkriterium = parentAkzeptanzkriterium;
        }

        public override ConceptNode GetConceptNode()
        {
            return _modelAssertion;
        }

        public Test_ Test(Action action)
        {
            var assertion = new Assertion(LabelConcept, action);
            ((AcceptanceCriterion) ParentAkzeptanzkriterium.GetConceptNode()).Add(assertion);

            return new Test_(assertion, ParentAkzeptanzkriterium);
        }

        public Feature Execute()
        {
            return Execute<Feature>();
        }
    }
}
