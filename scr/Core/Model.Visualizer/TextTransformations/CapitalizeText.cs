using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Visualizer
{
	public class CapitalizeText
	{
		/// <summary>
		/// Capitalizes every word. "foo bar demo" will become "Foo Bar Demo"
		/// </summary>
		public string GetCapitalized(string text)
		{
			var oldWords = text.Split(' ');
			var newWords = new string[oldWords.Length];

			for (int i = 0; i < oldWords.Length; i++)
			{
				if (IsReallyAWord(oldWords[i]))
					newWords[i] = CapitalizeWord(oldWords[i]);
				else
					newWords[i] = oldWords[i];
			}

			return String.Join(" ", newWords);
		}

		private string CapitalizeWord(string singleTextElement)
		{
			var newChar = Char.ToUpper(singleTextElement[0]);
			var chars = singleTextElement.ToCharArray();
			chars[0] = newChar;
			return new string(chars);
		}

		private bool IsReallyAWord(string singleTextElement)
		{
			if (singleTextElement.Length == 1)
				return false;

			if (Char.IsNumber(singleTextElement[0]))
				return false;

			return true;
		}
	}
}
