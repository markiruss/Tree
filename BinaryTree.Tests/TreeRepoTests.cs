using BinaryTree.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BinaryTree.Tests
{
    [TestClass]
    public class TreeRepoTests
    {
        ITreeRepo _treeRepo;

        public TreeRepoTests()
        {
            var serviceProvider = new ServiceCollection()
               .AddSingleton<ITreeRepo, TreeRepo>()
               .BuildServiceProvider();

            _treeRepo = serviceProvider.GetService<ITreeRepo>();
        }        

        [TestMethod]
        public async Task Save_Load_TreeSame()
        {
            var input = new int[] { 15, 10, 22, 4, 12, 18, 24 };
            var tree = new BinaryTree();
            tree.BuildTree(input.ToList());
            
            var expected = tree.WalkTree().ToArray();

            var fileName = await _treeRepo.SaveTree(tree);
            var loadedTree = await _treeRepo.ReadTree(fileName);

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