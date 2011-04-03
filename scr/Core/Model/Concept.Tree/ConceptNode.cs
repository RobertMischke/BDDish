using System;
using System.Collections.Generic;
using Seedworks.Lib.Persistance;

namespace BDDish.Model.Tree
{
    public abstract class ConceptNode : IPersistable, WithDateCreated
	{
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

		/// <summary>
		/// Feature, UserStory, etc.
		/// </summary>
        internal string LabelConcept { get; set; }
        internal string LabelBody { get; set; }

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
