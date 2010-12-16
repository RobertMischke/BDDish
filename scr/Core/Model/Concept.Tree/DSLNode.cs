using System;
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
        public abstract ConceptNode GetConceptNode();
        
        public readonly DSLNode Parent;

        protected DSLNode(DSLNode parent)
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

        public TRootNode Execute<TRootNode>() where TRootNode : DSLNode 
        {
            var rootNode = (TRootNode) GetRoot();
            new ModelExecuter().Run((Feature)rootNode.GetConceptNode());

            return rootNode;
        }
    }
}
