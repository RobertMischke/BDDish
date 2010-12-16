using BDDish.Model.Tree;

namespace BDDish.German
{
	public class Feature : Node
	{
		public const string LabelConcept = "Feature";

		private readonly Model.Feature _feature;

		public Feature(string beschreibung) : base(null)
		{

            _feature = new Model.Feature(LabelConcept, beschreibung);
		}

		public Anforderung Anforderung(string beschreibung)
		{
            var userStory = new Model.UserStory(German.Anforderung.LabelConcept, beschreibung, _feature);
			_feature.AddUserStory(userStory);
			return new Anforderung(userStory, this);
		}


	}
}