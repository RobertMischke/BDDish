using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;

namespace BDDish.Model
{
	public class AcceptanceCriterion : ConceptNode
	{
		public Context Context;
        public AssertionList Assertions = new AssertionList();

		public Customer ParentCustomer;
		
		public AcceptanceCriterion(string labelConcept, string acceptanceContent, Customer parentCustomer)
			: base(labelConcept, acceptanceContent)
		{
			ParentCustomer = parentCustomer;
		}

	    public bool IsDraft { get { return Context == null && Assertions.Count == 0; } }
        public bool HasContext { get { return Context != null; } }

	    public void Add(string labelConcept, IContextDescription contextDescription)
		{
			Context = new Context(labelConcept, contextDescription, this);
		}

        public void Add(Assertion assertion)
        {
            Assertions.Add(assertion);
        }

	    public AssertionList GetAllAssertions()
	    {
            if (IsDraft)
                return new AssertionList();

            if (Context == null)
                return Assertions;

	        return Context.GetAllAssertions();
	    }
	}
}
