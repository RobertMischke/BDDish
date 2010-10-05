using System;
using System.Collections.Generic;
using System.Linq;

namespace BDDish
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
					charList.Add(character); continue;
				}

				if (Char.IsUpper(character) && NextCharacterIsUpperCase(index, chars)){
					if (PreviousCharacterIsLowerCase(index, chars))
						charList.Add(' ');

					charList.Add(character); continue;
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

		private bool NextCharacterIsUpperCase(int index, char[] chars)
		{
			if (index > chars.Length)
				return false;

			return Char.IsUpper(chars[index + 1]);
		}

		private bool PreviousCharacterIsLowerCase(int index, char[] chars)
		{
			if (index == 0)
				return false;

			return Char.IsLower(chars[index - 1]);
		}
	}
}