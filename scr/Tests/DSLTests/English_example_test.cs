using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //    .As("the default customer").

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
    }
}
