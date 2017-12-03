using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTreeLibrary
{
    public class BinTree<T> : ICollection<T>
    {      
        protected Node<T> root; // the tree root
        protected IComparer<T> comparer;

        // Constructors

        public BinTree() : this(Comparer<T>.Default)
        {
        }

        public BinTree(IComparer<T> defaultComparer)
        {
            //The ?? operator is called the null-coalescing operator. 
            // It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand. 

            comparer = defaultComparer ?? throw new ArgumentNullException("Default comparer is null");
        }

        public BinTree(IEnumerable<T> collection) : this(collection, Comparer<T>.Default)
        {

        }

        public BinTree(IEnumerable<T> collection, IComparer<T> defaultComparer) : this(defaultComparer)
        {
            AddRange(collection);
        }

        // To get min value (the leftmost)
        public T MinValue
        {
            get
            {
                if (root == null)
                    throw new InvalidOperationException("Tree is empty");
                var current = root;
                while (current.Left != null)
                    current = current.Left;
                return current.Value;
            }
        }

        // To get max value (the rightmost)
        public T MaxValue
        {
            get
            {
                if (root == null)
                    throw new InvalidOperationException("Tree is empty");
                var current = root;
                while (current.Right != null)
                    current = current.Right;
                return current.Value;
            }
        }

        // To add every collection value to the tree
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var value in collection)
                Add(value);
        }

        // Traversal of the tree
        public IEnumerable<T> Inorder()
        {
            if (root == null)
                yield break;

            var stack = new Stack<Node<T>>();
            var node = root;

            while (stack.Count > 0 || node != null)
            {
                if (node == null)
                {
                    node = stack.Pop();
                    yield return node.Value;
                    node = node.Right;
                }
                else
                {
                    stack.Push(node);
                    node = node.Left;
                }
            }
        }        

        // ICollection<T> Members        

        // Count saves the number of tree nodes
        public int Count
        {
            get;
            protected set;
        }            

        // Add the item in the binary tree
        public virtual void Add(T item)
        {
            var node = new Node<T>(item);

            // if it is the first item
            if (root == null)
                root = node;
            // if it is not the first item
            else
            {
                Node<T> current = root, parent = null;

                while (current != null)
                {
                    parent = current;
                    
                    if (comparer.Compare(item, current.Value) < 0)
                        current = current.Left;                    
                    else
                        current = current.Right;
                }
                
                if (comparer.Compare(item, parent.Value) < 0)
                    parent.Left = node;
                else
                    parent.Right = node;
            }
            ++Count;
        }

        // Not implemented methods

        public bool IsReadOnly => throw new NotImplementedException();

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        
        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }  

        // IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return Inorder().GetEnumerator();
        }

        // IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        } 
    }
}