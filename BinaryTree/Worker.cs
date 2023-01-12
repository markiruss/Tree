using BinaryTree.Interfaces;

namespace BinaryTree
{
    internal class Worker : IWorker
    {
        IInputParser _inputParser;        
        ITreeRepo _treeRepo;
        IOutputBuilder _outputBuilder;

        public Worker(IInputParser inputParser, ITreeRepo treeRepo, IOutputBuilder outputBuilder)
        {
            _inputParser = inputParser;            
            _treeRepo = treeRepo;
            _outputBuilder = outputBuilder;
        }

        public async Task DoWork(string[] args)
        {            
            List<int> listOfInts;
            if (!_inputParser.ParseInput(args, out listOfInts))
            {
                Console.WriteLine("Please supply a comma separated list of positive numbers as an argument");
                return;
            }

            var tree = new BinaryTree();
            tree.BuildTree(listOfInts);

            await _treeRepo.SaveTree(tree);
                        
            string output = _outputBuilder.BuildOutput(tree);

            Console.WriteLine(output);            
        }
    }
}
