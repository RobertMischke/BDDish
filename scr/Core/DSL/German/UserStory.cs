using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.German
{
	public class UserStory
	{

		public Kunde Als(string name)
		{
			return new Kunde();
		}

		public Kunde Als(ICustomer kunde)
		{
			return new Kunde();
		}

	}
}
