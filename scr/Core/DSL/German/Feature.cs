using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class Feature
	{
		public const string LabelConcept = "Feature";

		private readonly BDDish.Feature _feature;

		public Feature(string beschreibung)
		{
			_feature = new BDDish.Feature(LabelConcept,beschreibung);
		}

		public Anforderung Anforderung(string beschreibung)
		{
			var userStory = new UserStory(German.Anforderung.LabelConcept, beschreibung, _feature);
			_feature.AddUserStory(userStory);
			return new Anforderung(userStory, this);
		}


	}
}