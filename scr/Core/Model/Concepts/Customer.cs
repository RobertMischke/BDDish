using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	/// <summary>
	/// The one who is paying for a feature or demanding the feature in order to archive the development goals.
	/// </summary>
	public class Customer : SpecificationPart 
	{
		public Customer(string content) : base(content)
		{
		}
	}
}
