using System;

namespace DataStructure.BinaryTree
{
    public class Node<T> : IComparable<T> where T : IComparable<T>
    {
        public Node(T value)
        {
            Value = value;
        }
        public T Value { get; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}
