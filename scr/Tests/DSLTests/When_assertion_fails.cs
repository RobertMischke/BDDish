using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests.DSLTests
{
	public class When_assertion_fails
	{
		public void Arrange_sample_feature_with_failing_test()
		{
			new German.Feature("Feature").
					Anforderung("Anforderung").
						Als(Auftraggeber.Normalo).
							AkzeptanzKriterium("Aktzeptanzkriterium1").
								Für(Sample.Order3Positions).
								Gilt("Foo", Is.EqualTo("Bla")).
								Gilt("Bla", Is.EqualTo("Bla"))

				.Execute();
		}

		[Ignore("Manual test")]
		[Test]
		public void The_output_should_be_complete_and_the_test_should_be_red()
		{
			Arrange_sample_feature_with_failing_test();
		}

	}
}
