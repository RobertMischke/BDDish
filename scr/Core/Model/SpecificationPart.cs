using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistance;

namespace BDDish
{
	public abstract class SpecificationPart : IMutablePersistable
	{
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

		/// <summary>
		/// Feature, UserStory, etc.
		/// </summary>
        public string LabelConcept { get; set; }

        public string LabelBody { get; set; }
		
		public string Label
		{
			get { return LabelConcept + ": " + LabelBody; }
		}

		protected SpecificationPart(){}

		protected SpecificationPart(string labelConcept)
		{
			LabelConcept = labelConcept;
		}

		protected SpecificationPart(string labelConcept, string labelBody) : this(labelConcept)
		{
			LabelBody = labelBody;
		}


	}
}
