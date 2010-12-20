using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;
using NUnit.Framework;

namespace BDDish.Tests
{
    public class SampleContext : IContextDescription 
    {
        private readonly Action _assertion;
        public string SampleDesciption { get; set; }

        public SampleContext(Action assertion){ _assertion = assertion; } //ctor

        public void Setup(){
            SampleDesciption = "Some description";

            _assertion.Invoke();
        }
    }

    public class Execution_order
    {
        private int _executionCount = 0;

        [Test]
        public void Execution_order_test()
        {
            var feature =
                new German.Feature("Schnittstellen").
                        Anforderung("FANTASYformat v1.0 exportieren").
                            Als(Auftraggeber.Normalo).
                                AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
                                    Test(() => { _executionCount++; ExecutionNoIs(1, "Test 1"); }).
                                AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
                                    Für(new SampleContext(() => { _executionCount++; ExecutionNoIs(2, "Für 2"); })).
                                    Gilt(() => { _executionCount++; ExecutionNoIs(3, "Gilt 3"); });

            Assert.That(_executionCount, Is.EqualTo(0));

            feature.Execute();

            Assert.That(_executionCount, Is.EqualTo(3));

        }

        public void ExecutionNoIs(int executionNo, string callingMethod)
        {
            Assert.That(_executionCount, Is.EqualTo(executionNo), callingMethod);
        }

    }
}
