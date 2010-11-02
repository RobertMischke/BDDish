using System;
using NUnit.Framework.Constraints;

namespace BDDish
{
	public class MethodSignatureToString
	{
		private readonly CamelCaseToText _camelCaseToText = new CamelCaseToText();

		public string GetString(Action<object, EqualConstraint> action)
		{
			throw new NotImplementedException();
		}

		public string GetString(Action action)
		{
			string methodName = action.Method.Name;

			//if (methodName.Contains("<"))
			//    return "No si";

			return _camelCaseToText.GetText(action.Method.Name);
		}


	}
}