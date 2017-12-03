using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeLibrary
{
    // Description of tree node
    public class Node<TValue>
    {
        // Node value
        public TValue Value
        {
            get;
            set;
        }

        // Link to the left node
        public Node<TValue> Left
        {
            get;
            set;
        }

        // Link to the right node
        public Node<TValue> Right
        {
            get;
            set;
        }

        // Constructor
        public Node(TValue value)
        {
            this.Value = value;
        }
    }
}
