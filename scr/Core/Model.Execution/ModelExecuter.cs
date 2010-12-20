﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;

namespace BDDish
{
	public class ModelExecuter
	{
	    private readonly ConsoleWriter _consoleWriter = new ConsoleWriter();
	    private readonly HtmlWriter _htmlWriter = new HtmlWriter();

		public void Run(Feature feature)
		{
		    _consoleWriter.Write(feature);

            if (Config.GenerateHtml)
                _htmlWriter.Write(feature);

            ExecuteAllAssertions(feature.GetAllAssertions());
		}

        private static void ExecuteAllAssertions(AssertionList assertions)
        {
            assertions.ForEach(assertion =>
            {
                if (assertion.Context != null && !assertion.Context.HasBeenSetup())
                    assertion.Context.Setup();

                try{assertion.Action();}
                catch (NotImplementedException e) { }
            });
        }

	}
}
