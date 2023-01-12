using BinaryTree.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Numerics;

namespace BinaryTree
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()            
                .AddSingleton<IInputParser, InputParser>()
                .AddSingleton<IOutputBuilder, OutputBuilder>()
                .AddSingleton<ITreeRepo, TreeRepo>()
                .AddSingleton<IWorker, Worker>()            
                .BuildServiceProvider();

            var worker = serviceProvider.GetService<IWorker>();

            await worker.DoWork(args);
        }       
    }
}