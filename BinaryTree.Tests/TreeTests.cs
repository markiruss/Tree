namespace BinaryTree.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void WalkTree_CorrectOrder()
        {
            var input = new int[] { 15, 10, 22, 4, 12, 18, 24 };
            var expected = new int[] { 4, 12, 10, 18, 24, 22, 15 };
            
            var tree = new BinaryTree();
            tree.BuildTree(input.ToList());

            var actual = tree.WalkTree().ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}