using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class CustomerList : List<Customer>
	{
	    public AssertionList GetAllAssertions()
	    {
	        var result = new AssertionList();

            foreach (var customer in this)
                result.Add(customer.GetAllAssertions());

            return result;
	    }
	}
}
