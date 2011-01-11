using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;
using BDDish.Model.Visualizer;
using NUnit.Framework.Constraints;

namespace BDDish.Model
{
	public class Context : ConceptNode
	{
		private readonly IContextDescription _internalDescription;

		public string Name;
		public string Description { get { return _internalDescription.SampleDesciption; } set { _internalDescription.SampleDesciption = value; } }

	    private bool _hasBeenSetup;
        public bool HasBeenSetup() { return _hasBeenSetup; }

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
			_internalDescription = new InternalDescription();
			ParentAceptanceCriterion = parentAcceptanceCriterion;
		}

		public Context(string labelConcept, IContextDescription contextDescription, AcceptanceCriterion parentAcceptanceCriterion)
			: base(labelConcept, new TextFormater().GetText(contextDescription.GetType().Name))
		{
			_internalDescription = contextDescription;
			ParentAceptanceCriterion = parentAcceptanceCriterion;
		}

		public void Add(Assertion assertion)
		{
			Assertions.Add(assertion);
		}

		public void Add(string labelConcept, Func<object> assertion, Func<EqualConstraint> equalTo)
		{
			Assertions.Add(new Assertion(labelConcept, assertion, equalTo, this));
		}

	    public AssertionList GetAllAssertions()
	    {
            return Assertions;
	    }

        public void Setup()
        {
            _internalDescription.Setup();
            _hasBeenSetup = true;
        }

	}
}
