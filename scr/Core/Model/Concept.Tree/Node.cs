using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Tree
{
    public class Node
    {
        public readonly Node Parent;

        public Node(Node parent)
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

        public Node GetRoot()
        {
            var currentNode = this;

            while (currentNode.HasParent())
                currentNode = currentNode.Parent;

            return currentNode;
        }


    }
}
