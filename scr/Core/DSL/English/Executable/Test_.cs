using System;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.English
{
    public class Test_ : DSLNode
    {
        public const string LabelConcept = "Test";

        private readonly Assertion _modelAssertion;
        public readonly AceptanceCriterion ParentAkzeptanzkriterium;

        public Test_(Assertion modelAssertion, AceptanceCriterion parentAkzeptanzkriterium)
            : base(parentAkzeptanzkriterium)
        {
            _modelAssertion = modelAssertion;
            ParentAkzeptanzkriterium = parentAkzeptanzkriterium;
        }

        internal override ConceptNode GetConceptNode()
        {
            return _modelAssertion;
        }

        public Test_ Test(Action action)
        {
            var assertion = new Assertion(LabelConcept, action, null);
            ((AcceptanceCriterion)ParentAkzeptanzkriterium.GetConceptNode()).Add(assertion);

            return new Test_(assertion, ParentAkzeptanzkriterium);
        }

        public AceptanceCriterion AkzeptanzKriterium(string beschreibung)
        {
            var parentAceptanceCriterion = (AcceptanceCriterion) ParentAkzeptanzkriterium.GetConceptNode();

            var modelAcceptanceCriterion = new AcceptanceCriterion(AceptanceCriterion.LabelConcept, beschreibung, (parentAceptanceCriterion.ParentCustomer));
            parentAceptanceCriterion.ParentCustomer.Add(modelAcceptanceCriterion);

            return new AceptanceCriterion(modelAcceptanceCriterion, ParentAkzeptanzkriterium.ParentCustomer);
        }

        public Feature Execute()
        {
            return Execute<Feature>();
        }

        public Test_ Bemerkung(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }
    }
}
