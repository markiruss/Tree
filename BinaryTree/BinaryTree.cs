using BinaryTree.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {        
        public void BuildTree(List<int> numbers)
        {
            Root = new Node(numbers[0]);
            for (int i = 1; i < numbers.Count; i++)
            {
                Root.Insert(numbers[i]);
            }
        }

        public IEnumerable<int> WalkTree()
        {
            if (Root != null)
            {
                return Root.WalkTree();
            }
            else
            {
                return Enumerable.Empty<int>();
            }            
        }

        public Node? Root { get; set; }

    }
}
