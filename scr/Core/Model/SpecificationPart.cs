using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public abstract class SpecificationPart
	{
		public string RenderedConceptName;
		public string Label;

		protected SpecificationPart(){}

		protected SpecificationPart(string label)
		{
			Label = label;
		}

	}
}
