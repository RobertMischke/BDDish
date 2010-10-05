using System;
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

			public void Setup(){}
		}

		public Context(string labelConcept, string labelBody, AcceptanceCriterion parentAcceptanceCriterion) : 
			base(labelConcept, labelBody)
		{
			_internalDesrciption = new InternalDescription();
			ParentAceptanceCriterion = parentAcceptanceCriterion;
		}

		public Context(string labelConcept, IContextDescription contextDescription, AcceptanceCriterion parentAcceptanceCriterion) 
			: base(labelConcept, contextDescription.Name )
		{
			_internalDesrciption = contextDescription;
			ParentAceptanceCriterion = parentAcceptanceCriterion;
		}

		public void Add(Assertion assertion)
		{
			Assertions.Add(assertion);
		}

		public void Add(string labelConcept, string assertion, EqualConstraint equalTo)
		{
			Assertions.Add(new Assertion(labelConcept, assertion, equalTo, this));
		}

	}
}
