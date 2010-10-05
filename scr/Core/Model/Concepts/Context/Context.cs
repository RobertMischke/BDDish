﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework.Constraints;

namespace BDDish
{
	public class Context : SpecificationPart
	{
		private readonly IContextDescription _internalDesrciption;

		public string Name { get { return _internalDesrciption.Name; } set { _internalDesrciption.Name = value; } }
		public string Description { get { return _internalDesrciption.Name; } set { _internalDesrciption.Name = value; } }

		public AssertionList Assertions = new AssertionList();
		
		public AcceptanceCriterion ParentAceptanceCriterion;

		private class InternalDescription : IContextDescription
		{
			public string Name { get; set; }
			public string Desciption { get; set; }

			public void Create(){}
		}

		public Context(){ _internalDesrciption = new InternalDescription(); }

		public Context(IContextDescription contextDescription)
		{
			_internalDesrciption = contextDescription;
		}

		public void Add(Assertion assertion)
		{
			Assertions.Add(assertion);
		}

		public void Add(string assertion, EqualConstraint equalTo)
		{
			Assertions.Add(new Assertion(assertion, equalTo));
		}
	}
}
