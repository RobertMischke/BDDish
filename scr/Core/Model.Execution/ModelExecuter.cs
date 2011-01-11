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

		public void Run(Feature feature)
		{
		    _consoleWriter.Write(feature);

            ExecuteAllAssertions(feature.GetAllAssertions());
		}

        private void ExecuteAllAssertions(AssertionList assertions)
        {
            assertions.ForEach(assertion =>
            {
                try { assertion.Action(); }
                catch (NotImplementedException) { }
            });
        }

	}
}
