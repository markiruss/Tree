namespace BinaryTree
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var inputParser = new InputParser();
            List<int> listOfInts;
            if(!inputParser.ParseInput(args, out listOfInts))
            {
                Console.WriteLine("Please supply a comma separated list of positive numbers as an argument");
                return;
            }

            var tree = new Tree(listOfInts[0]);

            for(int i = 1; i < listOfInts.Count; i++)
            {
                tree.Insert(listOfInts[i]);
            }

            var treeRepo = new TreeRepo();
            var fileName = await treeRepo.SaveTree(tree);            

            var outputBuilder = new OutputBuilder();
            string output = outputBuilder.BuildOutput(tree);

            Console.WriteLine(output);
        }

        public static void InputError()
        {
            Console.WriteLine("Please supply a comma separated list of positive numbers as an argument");
        }
    }
}