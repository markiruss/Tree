namespace BinaryTree.Tests
{
    [TestClass]
    public class OutputBuilderTests
    {
        [TestMethod]
        public void Builds_CorrectOrder()
        {
            var input = new int[] { 15, 10, 22, 4, 12, 18, 24 };
            var expected = "4, 12, 10, 18, 24, 22, 15";
            
            var tree = new Tree(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                tree.Insert(input[i]);
            }

            var outputBuilder = new OutputBuilder();
            string actual = outputBuilder.BuildOutput(tree);

            Assert.AreEqual(expected, actual);
        }
    }
}