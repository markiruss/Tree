using BinaryTree.Interfaces;
using System.Text.Json;

namespace BinaryTree
{
    public class TreeRepo : ITreeRepo
    {
        public async Task<string> SaveTree(BinaryTree tree)
        {
            string jsonTree = JsonSerializer.Serialize(tree, new JsonSerializerOptions { WriteIndented = true });
            string fileName = $"Tree{DateTime.UtcNow.Ticks}.json";
            await File.WriteAllTextAsync(fileName, jsonTree);
            return fileName;
        }

        public async Task<BinaryTree?> ReadTree(string filePath)
        {
            string jsonTree = await File.ReadAllTextAsync(filePath);
            var tree = JsonSerializer.Deserialize<BinaryTree>(jsonTree);
            return tree;
        }
    }
}
