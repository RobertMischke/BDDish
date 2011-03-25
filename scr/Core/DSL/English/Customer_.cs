using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.English
{
	public class Customer_ : DSLNode
	{
		public const string LabelConcept = "Als";

		private readonly Customer _modelCustomer;
        public readonly Requirement_ ParentRequirement;

		public Customer_(Customer modelCustomer, Requirement_ parentRequirement) : base(parentRequirement)
		{
			_modelCustomer = modelCustomer;
			ParentRequirement = parentRequirement;
		}

		public AceptanceCriterion AceptanceCriterion(string beschreibung)
		{
			var modelAcceptanceCriterion = new AcceptanceCriterion(English.AceptanceCriterion.LabelConcept , beschreibung, _modelCustomer);
			_modelCustomer.Add(modelAcceptanceCriterion);
			return new AceptanceCriterion(modelAcceptanceCriterion, this);
		}

        internal override ConceptNode GetConceptNode()
        {
            return _modelCustomer;
        }

        public Customer_ Note(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }
	}
}
