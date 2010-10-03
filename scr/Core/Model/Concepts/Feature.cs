using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class Feature : SpecificationPart
	{	
		public UserStoryList UserStories = new UserStoryList();
		public SponsorList Sponsors = new SponsorList();

		/// <summary>
		/// Acceptance criteria directly assigned to this Feature. 
		/// </summary>
		/// <remarks>
		/// These criteria don't have a user stories  assigned.
		/// </remarks>
		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();
		

		public Feature(string content) : base(content)
		{
		}

		public Feature AddUserStory(params UserStory[] userStories)
		{
			foreach(var userStory in userStories)
				UserStories.Add(userStory);

			return this;
		}

		public Feature AddSponsor(Sponsor sponsor)
		{
			Sponsors.Add(sponsor);
			return this;
		}

	}
}
