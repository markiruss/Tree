using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Interfaces
{
    public interface ITreeRepo
    {
        Task<string> SaveTree(ITree tree);
        Task<ITree?> ReadTree(string filePath);
    }
}
