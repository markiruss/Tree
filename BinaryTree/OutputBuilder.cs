using BinaryTree.Interfaces;
using System.Text;

namespace BinaryTree
{
    public class OutputBuilder : IOutputBuilder
    {
        public string BuildOutput(ITree tree)
        {
            var sb = new StringBuilder();

            foreach (var item in tree.WalkTree())
            {
                sb.Append($"{item}, ");
            }

            var output = sb.ToString();
            output = output.TrimEnd(' ', ',');
            return output;
        }
    }
}
