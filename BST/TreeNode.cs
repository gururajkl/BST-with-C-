namespace BST
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
        }

        public void Insert(T newValue)
        {
            int compare = newValue.CompareTo(Value);
            if (compare == 0) return;
            if (compare < 0)
            {
                if (Left == null)
                    Left = new TreeNode<T>(newValue);
                else
                {
                    Left.Insert(newValue);
                }
            }
            else
            {
                if (Right == null)
                    Right = new TreeNode<T>(newValue);
                else
                {
                    Right.Insert(newValue);
                }
            }
        }

        public TreeNode<T> Get(T value)
        {
            int compare = value.CompareTo(Value);
            if (compare == 0) return this;
            if (compare < 0)
            {
                if (Left != null)
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if (Right != null)
                {
                    Right.Insert(value);
                }
            }
            return null;
        }

        public IEnumerable<T> TraverseInorder()
        {
            var list = new List<T>();
            InnserTraverse(list);
            return list;
        }

        private void InnserTraverse(List<T> list)
        {
            if (Left != null)
                Left.InnserTraverse(list);

            list.Add(Value);

            if (Right != null)
                Right.InnserTraverse(list);
        }

        public T Min()
        {
            if (Left != null)
                Left.Min();
            return Value;
        }

        public T Max()
        {
            if (Right != null)
                Right.Max();
            return Value;
        }
    }
}
