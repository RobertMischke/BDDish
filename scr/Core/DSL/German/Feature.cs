using BDDish.DSL;
using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.German
{
	public class Feature : DSLNode
	{
		public const string LabelConcept = "Feature";

		private readonly Model.Feature _feature;

		public Feature(string titel) : base(null)
		{
            _feature = new Model.Feature(LabelConcept, titel);
		}

        public Feature Beschreibung(string beschreibung)
        {
            var featureDescription = new FeatureDescription("Beschreibung", beschreibung);
            _feature.AddDescription(featureDescription);
            return this;
        }

		public Anforderung Anforderung(string beschreibung)
		{
            var userStory = new UserStory(German.Anforderung.LabelConcept, beschreibung, _feature);
			_feature.AddUserStory(userStory);
			return new Anforderung(userStory, this);
		}

        internal override ConceptNode GetConceptNode()
        {
            return _feature;
        }

        public Feature Bemerkung(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }


	}
}