using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.DSL;
using BDDish.Model;

namespace BDDish.English
{
    public class EmptyContext : EmptyContextBase
    {
        public EmptyContext(Action action) : base(action, "")
        {
        }
    }
}
