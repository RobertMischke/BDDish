using System;
using System.Collections.Generic;
using System.Linq;

namespace BDDish.Tests
{
	public class CamelCaseToText
	{
		public string GetText(string camelCaseString)
		{
			var chars = camelCaseString.ToCharArray();

			var charList = new List<char>();
			var index = -1;
			foreach (var character in chars)
			{
				index++;

				if (index == 0){
					charList.Add(character);
					continue;
				}

				if (Char.IsUpper(character)){
					charList.Add(' ');
					charList.Add(Char.ToLower(character));
					continue;
				}

				charList.Add(character);
			}

			return String.Join("", charList);
		}
	}
}