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
            //new English.Feature("Example Feature")
            //    .Requirement("Some customer needs something")
            //    .Customer("the default customer").
            //        AceptanceCriterion("The need").
            //            Given(Some_context)

            /* 
             * Feature(Example).
             * Requirement("Sth should be")
             * For("the given customer")
             * 
             * Given(this context)
             * When()
             * Then()
             */

            /* 
             * Feature(Example).
             * Requirement("Sth should be")
             * As("the given customer")
             * 
             * Given(this context)
             * When()
             * ItsExpectedThat()
             */
        }

        private IContextDescription Some_context()
        {
            throw new NotImplementedException();
        }
    }
}
