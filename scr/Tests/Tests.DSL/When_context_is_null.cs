using System;
using BDDish.English;
using NUnit.Framework;

namespace BDDish.Tests.DSLTests
{
    public class When_context_is_null
    {
        public void Arrange_sample_feature_with_null_context()
        {
            new Feature("Feature").
                    Requirement("Anforderung").
                        As(Customers.Special).
                            AceptanceCriterion("Aktzeptanzkriterium1").
                            Given(some_context).
                            Then(we_expect_something).                
            Execute();
        }

        private EmptyContext some_context;
        Action we_expect_something = () => {};

        [Test]
        [ExpectedException("NUnit.Framework.IgnoreException")]
        public void Feature_should_be_throw_not_implemented_exception()
        {
            Arrange_sample_feature_with_null_context();            
        }
    }
}
