using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Interfaces
{
    public interface IWorker
    {
        Task DoWork(string[] args);
    }
}
