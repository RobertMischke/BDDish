using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model
{
	public class UserStoryList : List<UserStory>
	{
	    public AssertionList GetAllessertions()
	    {
	        var result = new AssertionList();

            foreach (var userStory in this)
                result.Add(userStory.GetAllAssertions());

            return result;
	    }
	}
}
