using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class Feature : Concept
	{	
		public string Content;

		public UserStory UserStory;

		public Feature(){}

		public Feature(string content)
		{
			Content = content;
		}
	}
}
