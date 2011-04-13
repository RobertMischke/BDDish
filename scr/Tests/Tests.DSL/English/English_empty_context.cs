using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.English;
using BDDish.Model;
using NUnit.Framework;

namespace BDDish.Tests
{
    public class English_empty_context
    {
        [Test]
        public void Example_Test()
        {
            new English.Feature("Example Feature")
                .Requirement("Some customer needs something")
                .Customer(Customers.Normal).
                    AceptanceCriterion("The need").
                        Given(some_context).
                        Then(we_expect_the_following).Execute();
        }

        private EmptyContext some_context = new EmptyContext(() => {});
        void we_expect_the_following(){}
    }
}
