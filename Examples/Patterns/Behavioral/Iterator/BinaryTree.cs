using Patterns.Behavioral.Iterator;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Behavioral.Iterator
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Node<T> _head;
        private int _count;

        public int Count { get => _count; }
        public void Add(T value)
        {
            if (_head == null)
            {
                _head = new Node<T>(value);
            }
            else
            {
                AddTo(_head, value);
            }
            _count++;
        }

        public bool Contains(T value)
        {
            Node<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        public bool Remove(T value)
        {
            Node<T> current;
            Node<T> parent;

            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }

            _count--;

            if (current.Right == null)
            {
                if (parent == null)
                {
                    _head = current.Left;
                }
                else
                {
                    var result = parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                {
                    _head = current.Right;
                }
                else
                {
                    var result = parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        parent.Left = current.Right;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Right;
                    }
                }
            }
            else
            {
                Node<T> leftmost = current.Right.Left;
                Node<T> leftmostParent = current.Right;

                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }

                leftmostParent.Left = leftmost.Right;
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                {
                    _head = leftmost;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        parent.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        parent.Right = leftmost;
                    }
                }
            }

            return true;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new InOrderTraversalIterator();
            //return InOrderTraversal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerator<T> InOrderTraversal()
        {
            if (_head != null)
            {
                var stack = new Stack<Node<T>>();
                var current = _head;

                var goLeftNext = true;

                stack.Push(current);

                while (stack.Count > 0)
                {
                    if (goLeftNext)
                    {
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }

                    yield return current.Value;

                    if (current.Right != null)
                    {
                        current = current.Right;
                        goLeftNext = true;
                    }
                    else
                    {
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }

        private void AddTo(Node<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        private Node<T> FindWithParent(T value, out Node<T> parent)
        {
            Node<T> current = _head;
            parent = null;

            while (current != null)
            {
                var result = current.CompareTo(value);

                if (result > 0)
                {
                    parent = current;
                    current = parent.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = parent.Right;
                }
                else
                {
                    break;
                }
            }
            return current;
        }
    }
}
