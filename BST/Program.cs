namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bst = new BST<int>();
            bst.Insert(37);
            bst.Insert(24);
            bst.Insert(17);
            bst.Insert(28);
            bst.Insert(31);
            bst.Insert(29);
            bst.Insert(15);
            bst.Insert(12);
            bst.Insert(20);

            Console.WriteLine(bst.Max());
            Console.WriteLine();
            foreach (var item in bst.TraverseInOrder())
            {
                Console.Write(item + " ");
            }
        }
    }
}