using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;

namespace BDDish.DSL
{
    public class EmptyContextBase : IContextDescription
    {
        private readonly Action _contextAction;
        public string SampleDesciption { get; set; }

        public EmptyContextBase(Action action, string description)
        {
            _contextAction = action;
            SampleDesciption = description;
        }

        public void Setup()
        {
            _contextAction.Invoke();
        }
    }
}
