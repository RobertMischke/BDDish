using System;

namespace BDDish.Tests
{
	public class MethodSignatureToString
	{
		public string GetString(Action sampleSignature)
		{
			return sampleSignature.Method.Name;
		}
	}
}