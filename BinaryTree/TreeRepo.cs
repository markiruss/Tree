using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeRepo
    {
        public async Task<string> SaveTree(Tree tree)
        {
            string jsonTree = JsonSerializer.Serialize(tree, new JsonSerializerOptions { WriteIndented = true });
            string fileName = $"Tree{DateTime.UtcNow.Ticks}.json";
            await File.WriteAllTextAsync(fileName, jsonTree);
            return fileName;
        }

        public async Task<Tree?> ReadTree(string filePath)
        {
            string jsonTree = await File.ReadAllTextAsync(filePath);
            var tree = JsonSerializer.Deserialize<Tree>(jsonTree);
            return tree;
        }
    }
}
