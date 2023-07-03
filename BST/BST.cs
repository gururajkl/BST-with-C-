namespace BST
{
    public class BST<T> where T : IComparable<T>
    {
        public TreeNode<T> root;

        public TreeNode<T> Get(T value)
        {
            return root?.Get(value);
        }

        public T Min()
        {
            if (root == null)
                throw new InvalidOperationException("Empty tree");
            return root.Min();
        }

        public T Max()
        {
            if (root == null)
                throw new InvalidOperationException("Empty tree");
            return root.Max();
        }

        public void Insert(T value)
        {
            if (root == null)
                root = new TreeNode<T>(value);
            else
                root.Insert(value);
        }

        public void Remove(T value)
        {
            root = Remove(root, value);
        }

        private TreeNode<T> Remove(TreeNode<T> subTreeRoot, T value)
        {
            if (subTreeRoot == null)
                return null;

            int compareTo = value.CompareTo(subTreeRoot.Value);

            if (compareTo < 0)
            {
                subTreeRoot.Left = Remove(subTreeRoot.Left, value);
            }
            else if (compareTo > 0)
            {
                subTreeRoot.Right = Remove(subTreeRoot.Right, value);
            }
            else
            {
                if (subTreeRoot.Left == null)
                    return subTreeRoot.Right;
                if (subTreeRoot.Right == null)
                    return subTreeRoot.Left;

                subTreeRoot.Value = subTreeRoot.Right.Value;
                subTreeRoot.Right = Remove(subTreeRoot.Right, subTreeRoot.Value);
            }
            return subTreeRoot;
        }

        public IEnumerable<T> TraverseInOrder()
        {
            if (root != null) return root.TraverseInorder();
            return Enumerable.Empty<T>();
        }
    }
}
