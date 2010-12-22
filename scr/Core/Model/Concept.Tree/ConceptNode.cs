using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Tree
{
	public abstract class ConceptNode
	{
		/// <summary>
		/// Feature, UserStory, etc.
		/// </summary>
		internal string LabelConcept;

        internal string LabelBody;

        internal string Label
		{
			get { return LabelConcept + ": " + LabelBody; }
		}

        /// <summary>
        /// Containing notes for the current Node
        /// </summary>
	    public List<Note> Notes = new List<Note>();

		protected ConceptNode(string labelConcept)
		{
			LabelConcept = labelConcept;
		}

		protected ConceptNode(string labelConcept, string labelBody) : this(labelConcept)
		{
			LabelBody = labelBody;
		}

        internal void AddNote(string labelConcept, string note)
        {
            Notes.Add(new Note(labelConcept, note));
        }

	}
}
