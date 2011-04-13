using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.English;
using NUnit.Framework;

namespace BDDish.Tests.DSLTests
{
    public class When_assertion_is_null
    {
        public void Arrange_sample_feature_with_null_assertion()
        {
            new Feature("Feature").
                    Requirement("Anforderung").
                        As(Customers.Special).
                            AceptanceCriterion("Aktzeptanzkriterium1").
                            Given(some_context).
                            Then(we_expect_something).
            Execute(this);
        }

        private EmptyContext some_context = new EmptyContext(()=>{});
        Action we_expect_something;

        [Test]
        [ExpectedException("NUnit.Framework.IgnoreException")]
        public void Feature_should_be_throw_not_implemented_exception()
        {
            Arrange_sample_feature_with_null_assertion();
        }

    }
}
