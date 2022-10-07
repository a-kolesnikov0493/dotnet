using System.Collections;

namespace Patterns.Behavioral.Iterator
{
    public class DepthEnumerator : IEnumerator
    {
        private Tree _tree;
        public DepthEnumerator(Tree tree)
        {
            _tree = tree;
        }
        public object Current => throw new System.NotImplementedException();

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
