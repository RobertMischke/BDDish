using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using NUnit.Framework.Constraints;

namespace BDDish.Model.Visualizer
{
	public class MethodSignatureToString
	{
		private readonly TextFormater _textFormater = new TextFormater();

		public string GetString(Action<object, EqualConstraint> action)
		{
			throw new NotImplementedException();
		}

        public string GetString(Expression<Action> expression)
        {
            return "";
        }


        public string GetString(Action action)
        {
            if (action == null)
                return "not implemented";

            //object[] attributes = info.GetCustomAttributes(typeof(CompilerGeneratedAttribute)).Any()
            if (action.Target == null)
            {
                //ToDo: use Cecil to print MethodBody
                return "unknown assertion";
            }

            return _textFormater.GetText(action.Method.Name);
        }


	}
}