using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Interfaces
{
    public interface ITree
    {
        void Insert(int num);
        IEnumerable<int> WalkTree();

        int Value { get; set; }
        Tree? LeftNode { get; set; }
        Tree? RightNode { get; set; }
    }
}
