﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Tree
{
    /// <summary>
    /// Base type for Nodes in specific DSLs (For example German)
    /// </summary>
    public abstract class DSLNode
    {
        internal abstract ConceptNode GetConceptNode();

        protected readonly DSLNode Parent;

        protected DSLNode(DSLNode parent)
        {
            Parent = parent;
        }

        protected bool IsRootNode()
        {
            return !HasParent();
        }

        protected bool HasParent()
        {
            return Parent != null;
        }

        protected DSLNode GetRoot()
        {
            var currentNode = this;

            while (currentNode.HasParent())
                currentNode = currentNode.Parent;

            return currentNode;
        }

        protected TRootNode Execute<TRootNode>() where TRootNode : DSLNode 
        {
            var rootNode = (TRootNode) GetRoot();
            new ModelExecuter().Run((Feature)rootNode.GetConceptNode());

            return rootNode;
        }

        protected void AddNote(string labelNote, string note)
        {
            GetConceptNode().AddNote(labelNote, note);
        }
    }
}
