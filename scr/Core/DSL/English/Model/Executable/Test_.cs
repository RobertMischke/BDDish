using System;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.English
{
    public class Test_ : DSLNode
    {
        public const string LabelConcept = "Test";

        private readonly Assertion _modelAssertion;
        public readonly AceptanceCriterion_ ParentAceptanceCriterion;

        public Test_(Assertion modelAssertion, AceptanceCriterion_ parentAceptanceCriterion)
            : base(parentAceptanceCriterion)
        {
            _modelAssertion = modelAssertion;
            ParentAceptanceCriterion = parentAceptanceCriterion;
        }

        internal override ConceptNode GetConceptNode()
        {
            return _modelAssertion;
        }

        public Test_ Test(Action action)
        {
            var assertion = new Assertion(LabelConcept, action, null);
            ((AcceptanceCriterion)ParentAceptanceCriterion.GetConceptNode()).Add(assertion);

            return new Test_(assertion, ParentAceptanceCriterion);
        }

        public AceptanceCriterion_ AceptanceCriterion(string beschreibung)
        {
            var parentAceptanceCriterion = (AcceptanceCriterion) ParentAceptanceCriterion.GetConceptNode();

            var modelAcceptanceCriterion = new AcceptanceCriterion(English.AceptanceCriterion_.LabelConcept, beschreibung, (parentAceptanceCriterion.ParentCustomer));
            parentAceptanceCriterion.ParentCustomer.Add(modelAcceptanceCriterion);

            return new AceptanceCriterion_(modelAcceptanceCriterion, ParentAceptanceCriterion.ParentCustomer);
        }

        public Feature Execute(object sender)
        {
            return Execute<Feature>(sender);
        }

        public Test_ Bemerkung(string text)
        {
            AddNote(Words.LabelNote, text);
            return this;
        }
    }
}
