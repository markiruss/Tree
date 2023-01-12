using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Interfaces
{
    public interface IInputParser
    {
        bool ParseInput(string[] args, out List<int> parsedInput);
    }
}
