using BinaryTree.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BinaryTree.Tests
{
    [TestClass]
    public class OutputBuilderTests
    {
        IOutputBuilder _outputBuilder;

        public OutputBuilderTests()
        {
            var serviceProvider = new ServiceCollection()                
                .AddSingleton<IOutputBuilder, OutputBuilder>()                
                .BuildServiceProvider();

            _outputBuilder = serviceProvider.GetService<IOutputBuilder>();
        }

        [TestMethod]
        public void Builds_CorrectOrder()
        {
            var input = new int[] { 15, 10, 22, 4, 12, 18, 24 };
            var expected = "4, 12, 10, 18, 24, 22, 15";
            
            var tree = new BinaryTree();
            tree.BuildTree(input.ToList());

            string actual = _outputBuilder.BuildOutput(tree);

            Assert.AreEqual(expected, actual);
        }
    }
}