using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Visualizer;
using NUnit.Framework.Constraints;

namespace BDDish.Model
{
	public class Context : SpecificationPart
	{
		private readonly IContextDescription _internalDesrciption;

		public string Name;
		public string Description { get { return _internalDesrciption.SampleDesciption; } set { _internalDesrciption.SampleDesciption = value; } }

		public AssertionList Assertions = new AssertionList();
		
		public AcceptanceCriterion ParentAceptanceCriterion;

		private class InternalDescription : IContextDescription
		{
			public string SampleDesciption { get; set; }

			public void Setup(){}
		}

		public Context(string labelConcept, string labelBody, AcceptanceCriterion parentAcceptanceCriterion) : 
			base(labelConcept, labelBody)
		{
			_internalDesrciption = new InternalDescription();
			ParentAceptanceCriterion = parentAcceptanceCriterion;
		}

		public Context(string labelConcept, IContextDescription contextDescription, AcceptanceCriterion parentAcceptanceCriterion)
			: base(labelConcept, new TextFormater().GetText(contextDescription.GetType().Name))
		{
			_internalDesrciption = contextDescription;
			ParentAceptanceCriterion = parentAcceptanceCriterion;
			contextDescription.Setup();
		}

		public void Add(Assertion assertion)
		{
			Assertions.Add(assertion);
		}

		public void Add(string labelConcept, object assertion, EqualConstraint equalTo)
		{
			Assertions.Add(new Assertion(labelConcept, assertion, equalTo, this));
		}

	    public AssertionList GetAllAssertions()
	    {
            return Assertions;
	    }
	}
}
