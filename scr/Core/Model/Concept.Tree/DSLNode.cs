using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Tree
{
    /// <summary>
    /// Base type for Node ind specific DSLs (For example German)
    /// </summary>
    public class DSLNode
    {
        /// <summary>
        /// The underlying concept
        /// </summary>
        public ConceptNode Concept;
        public readonly DSLNode Parent;

        public DSLNode(DSLNode parent)
        {
            Parent = parent;
        }

        public bool IsRootNode()
        {
            return !HasParent();
        }

        public bool HasParent()
        {
            return Parent != null;
        }

        public DSLNode GetRoot()
        {
            var currentNode = this;

            while (currentNode.HasParent())
                currentNode = currentNode.Parent;

            return currentNode;
        }


    }
}
