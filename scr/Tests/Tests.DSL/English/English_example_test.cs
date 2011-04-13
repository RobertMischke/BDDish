using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;
using NUnit.Framework;

namespace BDDish.Tests
{
    public class English_example_test
    {
        [Test]
        public void Example_Test()
        {
            new English.Feature("Example Feature")
                .Requirement("Some customer needs something")
                .Customer(Customers.Normal).
                    AceptanceCriterion("The need").
                        Given(Some_context).
                        Then(We_expect_the_following).Execute(this);
        }

        private IContextDescription Some_context(){ return Sample.Order1Position; }
        private void We_expect_the_following(){ Assert.That("bla", Is.EqualTo("bla")); }

    }
}
