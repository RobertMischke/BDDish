using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	/// <summary>
	/// The one who is paying for a feature or demanding the feature in order to archive the development goals.
	/// </summary>
	public class Customer : SpecificationPart
	{

		private readonly CustomerDescription _customerDesciption;

		private class CustomerDescription : ICustomer
		{
			public string Name { get; set; }
			public string Desription { get; set; }
		}

		public string Name { get { return _customerDesciption.Name; } set { _customerDesciption.Name = value; } }
		public string Desription { get { return _customerDesciption.Desription; } set { _customerDesciption.Desription = value; } }

		public Customer(string content) : base(content)
		{
			_customerDesciption = new CustomerDescription();
			Name = content;
		}

		public Customer(ICustomer customer)
		{
			_customerDesciption = (CustomerDescription) customer;
		}

	}
}
