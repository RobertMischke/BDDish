using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;
using NUnit.Framework;

namespace BDDish
{
	public class ModelExecuter
	{
	    private readonly ConsoleWriter _consoleWriter = new ConsoleWriter();

		public void Run(Feature feature)
		{
		    _consoleWriter.Write(feature);

            ExecuteAllAssertions(feature.GetAllAssertions());
		}

        private static void ExecuteAllAssertions(AssertionList assertions)
        {
            assertions.ForEach(assertion =>
            {
                if (assertion.Context != null && !assertion.Context.HasBeenSetup())
                {
                    if (assertion.Context.IsContextEmpty())
                        Assert.Ignore("context has not been implemented");

                    assertion.Context.Setup();
                    foreach (var contextSetting in assertion.Context.Settings)
                        try
                            { contextSetting.Action.Invoke(); }
                        catch (NotImplementedException)
                            { Assert.Ignore(); }                
                }

                if (assertion.Action == null)
                    Assert.Ignore();

                try
                    {assertion.Action();}
                catch (NotImplementedException)
                    { Assert.Ignore(); }
            });
        }

	}
}
