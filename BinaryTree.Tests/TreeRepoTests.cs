namespace BinaryTree.Tests
{
    [TestClass]
    public class TreeRepoTests
    {
        [TestMethod]
        public async Task Save_Load_TreeSame()
        {
            var input = new int[] { 15, 10, 22, 4, 12, 18, 24 };
            var tree = new Tree(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                tree.Insert(input[i]);
            }
            var expected = tree.WalkTree().ToArray();

            var treeRepo = new TreeRepo();

            var fileName = await treeRepo.SaveTree(tree);
            var loadedTree = await treeRepo.ReadTree(fileName);

            int[] actual;
            if (loadedTree != null)
            {
                actual = loadedTree.WalkTree().ToArray();
            }
            else
            {
                actual = new int[0];
            }            

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}