using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public abstract class SpecificationPart
	{
		/// <summary>
		/// Feature, UserStory, etc.
		/// </summary>
		public string LabelConcept;

		public string LabelBody;
		
		public string Label
		{
			get { return LabelConcept + ":" + LabelBody; }
		}

		protected SpecificationPart(){}

		protected SpecificationPart(string labelConcept, string labelBody)
		{
			LabelConcept = labelConcept;
			LabelBody = labelBody;
		}

	}
}
