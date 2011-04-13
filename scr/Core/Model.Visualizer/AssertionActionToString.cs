using System;
using System.Diagnostics;
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


        public string GetString(Action action, object sender = null)
        {
            if (action == null)
                return "not implemented";


            //Alternativ: object[] attributes = info.GetCustomAttributes(typeof(CompilerGeneratedAttribute)).Any())
            if (action.Target == null) //Wenn es sich um eine anonyme Methode handelt
            {

                if (sender != null)
                {
                    var fielHoldingTheAction = GetFieldDefintionHoldingTheAction(action, sender);
                    if (fielHoldingTheAction != null)
                        return _textFormater.GetText(fielHoldingTheAction.Name);
                }

                 //ToDo: use Cecil to print MethodBody
                return "unknown assertion";
            }

            return _textFormater.GetText(action.Method.Name);
        }

        private static MemberInfo GetFieldDefintionHoldingTheAction(Action action, object sender)
        {
            var memberFields = action.Method.DeclaringType.GetMembers(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                                                      BindingFlags.NonPublic | BindingFlags.GetField).
                                                           Where(member => member.MemberType == MemberTypes.Field);

            foreach (var memberField in memberFields)
            {
                var fieldInfo = ((FieldInfo)memberField);

                if (ReferenceEquals(fieldInfo.GetValue(sender), action))
                    return memberField;

            }

            return null;
        }


	}
}