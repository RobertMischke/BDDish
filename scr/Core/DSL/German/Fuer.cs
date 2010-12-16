using System;
using BDDish.Model.Tree;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using BDDish.Model;

namespace BDDish.German
{
	public class Für : DSLNode
	{
		public const string LabelConcept = "Für";

		private readonly Context _modelContext;
		public AkzeptanzKriterium_ ParentAkzeptanzkriterium;

		public Für(Context modelContext, AkzeptanzKriterium_ parentAkzeptanzkriterium) : base(parentAkzeptanzkriterium)
		{
			_modelContext = modelContext;
			ParentAkzeptanzkriterium = parentAkzeptanzkriterium;
		}

		public Gilt_ Gilt(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(Gilt_.LabelConcept, asssertionAction, _modelContext));
			return new Gilt_(_modelContext, this);
		}

		public Gilt_ Gilt(object assertion, EqualConstraint equalTo)
		{
			_modelContext.Add(Gilt_.LabelConcept, assertion, equalTo);
			return new Gilt_(_modelContext, this);
		}
	}
}