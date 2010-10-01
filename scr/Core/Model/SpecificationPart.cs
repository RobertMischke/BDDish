using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public abstract class SpecificationPart
	{
		public string RenderedConceptName;
		public string Content;

		protected SpecificationPart(){}

		protected SpecificationPart(string content)
		{
			Content = content;
		}

	}
}
