﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Tree
{
	public abstract class SpecificationNode
	{
		/// <summary>
		/// Feature, UserStory, etc.
		/// </summary>
		public string LabelConcept;

		public string LabelBody;
		
		public string Label
		{
			get { return LabelConcept + ": " + LabelBody; }
		}

		protected SpecificationNode(){}

		protected SpecificationNode(string labelConcept)
		{
			LabelConcept = labelConcept;
		}

		protected SpecificationNode(string labelConcept, string labelBody) : this(labelConcept)
		{
			LabelBody = labelBody;
		}

	}
}
