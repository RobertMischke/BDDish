using BDDish.Model;
using BDDish.Model.Tree;

namespace BDDish.English
{
	public class Feature : DSLNode
	{
		public const string LabelConcept = "Feature";

		private readonly Model.Feature _feature;

		public Feature(string titel) : base(null)
		{
            _feature = new Model.Feature(LabelConcept, titel);
		}

        public Feature Description(string description)
        {
            var featureDescription = new FeatureDescription("Beschreibung", description);
            _feature.AddDescription(featureDescription);
            return this;
        }

		public Requirement_ Requirement(string description)
		{
            var userStory = new UserStory(German.Anforderung.LabelConcept, description, _feature);
			_feature.AddUserStory(userStory);
			return new Requirement_(userStory, this);
		}

        internal override ConceptNode GetConceptNode()
        {
            return _feature;
        }

        public Feature Note(string text)
        {
            AddNote(Words.LabelBemerkung, text);
            return this;
        }


	}
}