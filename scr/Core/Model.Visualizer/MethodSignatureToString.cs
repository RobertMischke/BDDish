using System;

namespace BDDish
{
	public class MethodSignatureToString
	{
		private readonly CamelCaseToText _camelCaseToText = new CamelCaseToText();

		public string GetString(Action sampleSignature)
		{
			return _camelCaseToText.GetText(sampleSignature.Method.Name);
		}
	}
}