using BinaryTree.Interfaces;

namespace BinaryTree
{
    internal class Worker : IWorker
    {
        IInputParser _inputParser;
        ITree _tree;
        ITreeRepo _treeRepo;
        IOutputBuilder _outputBuilder;

        public Worker(IInputParser inputParser, ITree tree, ITreeRepo treeRepo, IOutputBuilder outputBuilder)
        {
            _inputParser = inputParser;
            _tree = tree;
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
                        
            for (int i = 1; i < listOfInts.Count; i++)
            {
                _tree.Insert(listOfInts[i]);
            }

            await _treeRepo.SaveTree(_tree);
                        
            string output = _outputBuilder.BuildOutput(_tree);

            Console.WriteLine(output);            
        }
    }
}
