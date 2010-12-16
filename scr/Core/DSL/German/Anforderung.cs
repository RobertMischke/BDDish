using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.German
{
	public class Anforderung : DSLNode
	{
		public const string LabelConcept = "Anforderung";
		public Feature ParentFeature;

		public UserStory _modelUserStory;

        public Anforderung(UserStory modelUserStory, Feature parentFeature) : base(parentFeature)
		{
			_modelUserStory = modelUserStory;
			ParentFeature = parentFeature;
		}

		public Kunde Als(string name)
		{
			var modelCustomer = new Customer(Kunde.LabelConcept, name, _modelUserStory);
			_modelUserStory.AddCustomer(modelCustomer);
			return new Kunde(modelCustomer, this);
		}

		public Kunde Als(ICustomerDescription kunde)
		{
			var modelCustomer = new Customer(Kunde.LabelConcept, kunde, _modelUserStory);
			_modelUserStory.AddCustomer(modelCustomer);
			return new Kunde(modelCustomer, this);
		}

        public override ConceptNode GetConceptNode()
        {
            return _modelUserStory;
        }

	}
}
