﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;

namespace BDDish.Model
{
	public class UserStory : ConceptNode
	{
		public CustomerList Customers = new CustomerList();
		
		public Feature ParentFeature;

		public UserStory(string labelConcept, string labelBody, Feature parentFeature) : 
			base(labelConcept, labelBody)
		{
			ParentFeature = parentFeature;
		}


		public void AddCustomer(Customer customer)
		{
			Customers.Add(customer);
		}

	    public AssertionList GetAllAssertions()
	    {
	        return Customers.GetAllAssertions();
	    }
	}
}
