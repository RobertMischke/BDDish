using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class Anforderung
	{
		public const string LabelConcept = "Anforderung";

		public UserStory _modelUserStory;
		public Customer _modelCustomer;

		public Anforderung(UserStory modelUserStory)
		{
			_modelUserStory = modelUserStory;
		}

		public Kunde Als(string name)
		{
			var modelCustomer = new Customer(Kunde.LabelConcept, name, _modelUserStory);
			_modelUserStory.AddCustomer(modelCustomer);
			return new Kunde(modelCustomer);
		}

		public Kunde Als(ICustomerDescription kunde)
		{
			var modelCustomer = new Customer(Kunde.LabelConcept, kunde, _modelUserStory);
			_modelUserStory.AddCustomer(modelCustomer);
			return new Kunde(modelCustomer);
		}

	}
}
