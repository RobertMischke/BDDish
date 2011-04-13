using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using NUnit.Framework.Constraints;

namespace BDDish.Model.Visualizer
{
	public class AssertionActionToString
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

            //Alternativ: object[] attributes = info.GetCustomAttributes(typeof(CompilerGeneratedAttribute)).Any()
            if (action.Target == null) //Wenn es sich um eine anonyme Methode handelt
            {
                //var members = action.Method.DeclaringType.GetMembers(BindingFlags.Public | BindingFlags.Instance |BindingFlags.Static | 
                //                                                     BindingFlags.NonPublic |BindingFlags.GetField).
                //                                          Where(member => member.MemberType == MemberTypes.Field);

                //foreach (var member in members)
                //{
                //    var foo = ((FieldInfo) member);

                //    if (ReferenceEquals(foo.GetValue(action.Method.DeclaringType), action))
                //    {
                //        return _textFormater.GetText(member.Name);
                //    }
                        
                //}


                //ToDo: use Cecil to print MethodBody
                return "unknown assertion";
            }

            return _textFormater.GetText(action.Method.Name);
        }


	}
}