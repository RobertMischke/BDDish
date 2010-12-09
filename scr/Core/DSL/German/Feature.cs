using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;

namespace BDDish.German
{
	public class Feature
	{
		public const string LabelConcept = "Feature";

		private readonly BDDish.Model.Concept.Feature _feature;

		public Feature(string beschreibung)
		{

            _feature = new BDDish.Model.Concept.Feature(LabelConcept, beschreibung);
		}

		public Anforderung Anforderung(string beschreibung)
		{
            var userStory = new BDDish.Model.Concept.UserStory(German.Anforderung.LabelConcept, beschreibung, _feature);
			_feature.AddUserStory(userStory);
			return new Anforderung(userStory, this);
		}


	}
}