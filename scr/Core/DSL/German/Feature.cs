using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class Feature
	{
		private readonly BDDish.Feature _feature;

		public Feature(string beschreibung)
		{
			_feature = new BDDish.Feature(beschreibung);
		}

		public Anforderung Anforderung(string beschreibung)
		{
			var userStory = new UserStory(beschreibung);
			_feature.AddUserStory(userStory);
			return new Anforderung(userStory);
		}


	}
}