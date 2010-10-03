using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class Feature
	{
		public Feature(string beschreibung)
		{
			throw new NotImplementedException();
		}

		public UserStory UserStory(string beschreibung)
		{
			return new UserStory();
		}
	}
}
