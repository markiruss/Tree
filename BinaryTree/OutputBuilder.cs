using System.Text;

namespace BinaryTree
{
    public class OutputBuilder
    {
        public string BuildOutput(Tree tree)
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
