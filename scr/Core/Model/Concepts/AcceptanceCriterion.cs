using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class AcceptanceCriterion : SpecificationPart
	{
		public Context Context;
		public CustomerList Customers = new CustomerList();
		public AssertionList Assertions = new AssertionList();
		
		public AcceptanceCriterion(string content, AssertionList assertions) : base(content)
		{
			Assertions.Add(assertions);
		}

		public AcceptanceCriterion(Customer customer, string acceptanceContent, AssertionList assertions) : base(acceptanceContent)
		{
			Customers.Add(customer);
			Assertions.Add(assertions);
		}

		public AcceptanceCriterion(Customer customer, string acceptanceContent)
			: base(acceptanceContent)
		{
			Customers.Add(customer);
		}


		public void AddContext(IContextDescription contextDescription)
		{
			Context = new Context(contextDescription);
		}
	}
}
