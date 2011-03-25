using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.English
{
	public class Requirement_ : DSLNode
	{
		public const string LabelConcept = "Anforderung";
        public readonly Feature ParentFeature;

		public UserStory _modelUserStory;

        public Requirement_(UserStory modelUserStory, Feature parentFeature) : base(parentFeature)
		{
			_modelUserStory = modelUserStory;
			ParentFeature = parentFeature;
		}

		public Customer_ As(string name)
		{
			var modelCustomer = new Customer(Customer_.LabelConcept, name, _modelUserStory);
			_modelUserStory.AddCustomer(modelCustomer);
			return new Customer_(modelCustomer, this);
		}

		public Customer_ As(ICustomerDescription kunde)
		{
			var modelCustomer = new Customer(Customer_.LabelConcept, kunde, _modelUserStory);
			_modelUserStory.AddCustomer(modelCustomer);
			return new Customer_(modelCustomer, this);
		}

        internal override ConceptNode GetConceptNode()
        {
            return _modelUserStory;
        }

        public Requirement_ Note(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }

	}
}
