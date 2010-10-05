using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

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

				if (IsTheBeginningOfANumber(index, chars)){
					charList.Add(' ');
					charList.Add(character); continue;
				}
					
				if (ItIsTheLastCharacterAndThisAndPreviousCharAreUpperCase(index, chars)){
					charList.Add(character); continue;
				}

				if (ThisAndNextCharacterIsUpperCase(index, chars)){
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

		private bool IsTheBeginningOfANumber(int index, char[] chars)
		{
			if (IsFirst(index))
				return false;

			if (Char.IsNumber(PreviousChar(index, chars)))
				return false;

			if (Char.IsNumber(ThisChar(index, chars)))
				return true;

			return false;
		}

		private bool ThisAndNextCharacterIsUpperCase(int index, char[] chars)
		{
			if (!Char.IsUpper(ThisChar(index, chars)))
				return false;

			if (index >= chars.Length - 1)
				return false;

			return Char.IsUpper(chars[index + 1]);
		}

		private bool PreviousCharacterIsLowerCase(int index, char[] chars)
		{
			if (IsFirst(index)) 
				return false;

			return Char.IsLower(PreviousChar(index, chars));
		}

		private bool ItIsTheLastCharacterAndThisAndPreviousCharAreUpperCase(int index, char[] chars)
		{
			if (!IsLast(index, chars))
				return false;

			if (IsFirst(index))
				return false;

			return Char.IsUpper(PreviousChar(index, chars));
		}

		private bool IsFirst(int index)
		{
			if (index == 0)
				return true;

			return false;
		}

		private bool IsLast(int index, char[] chars)
		{
			if (index == chars.Length -1)
				return true;

			return false;
		}

		private char PreviousChar(int index, char[] chars)
		{
			return chars[index - 1];
		}

		private char ThisChar(int index, char[] chars)
		{
			return chars[index];
		}

		public string GetTextCapitalized(string camelCaseString)
		{
			return new CapitalizeText().GetCapitalized(GetText(camelCaseString));		
		}
	}
}